using DataAccess.Interface;
using System.Threading.Tasks;
using UnitOfWork.EF.IRepository;
using UnitOfWork.EF.Repository;
using UnitOfWork.UnitOfWork.Interface;

namespace UnitOfWork.UnitOfWork
{
    public class UnitOfWorkEF : IUnitOfWorkEF
    {
        readonly IApplicationDbContext context;

        public static object singleton { get; set; }
        public UnitOfWorkEF(IApplicationDbContext _context)
        {
            context = _context;
        }

        public int Commit()
        {
            return context.SaveChanges();
        }

        public async Task<int> CommitAsync()
        {
            return await context.SaveChangesAsync();
        }

        #region Register
        private IBaoCaoRepositoryEF _baoCaoRepositoryEF { get; set; }
        public IBaoCaoRepositoryEF baoCaoRepositoryEF
        {
            get
            {
                if (_baoCaoRepositoryEF == null)
                {
                    _baoCaoRepositoryEF = new BaoCaoRepositoryEF(context);
                }
                return _baoCaoRepositoryEF;
            }
        }
        #endregion
    }
}
