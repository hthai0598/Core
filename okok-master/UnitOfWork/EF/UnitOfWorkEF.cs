using DataAccess.Interface;
using System.Threading.Tasks;
using UnitOfWork.EF.IRepository;
using UnitOfWork.EF.Repository;
using UnitOfWork.UnitOfWork.Interface;

namespace UnitOfWork.UnitOfWork
{
    public class UnitOfWorkEF<T> : IUnitOfWorkEF<T> where T : class
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
        private IRepositoryEF<T> _repositoryEF { get; set; }
        public IRepositoryEF<T> repositoryEF
        {
            get
            {
                if (_repositoryEF == null)
                {
                    _repositoryEF = new RepositoryEF<T>(context);
                }
                return _repositoryEF;
            }
        }


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
