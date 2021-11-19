using BCDT.Core.Data;
using DataAccess.Interface;
using System.Collections.Generic;
using System.Threading.Tasks;
using UnitOfWork.EF.IRepository;
using UnitOfWork.EF.Repository;
using System.Collections;
using UnitOfWork.UnitOfWork.Interface;

namespace UnitOfWork.UnitOfWork
{
    public class UnitOfWorkEF : IUnitOfWorkEF
    {
        readonly IApplicationDbContext _context;

        public UnitOfWorkEF(IApplicationDbContext context)
        {
            _context = context;
        }

        public int Commit()
        {
            return _context.SaveChanges();
        }

        public async Task<int> CommitAsync()
        {
            return await _context.SaveChangesAsync();
        }

        #region Register
        private Hashtable repositoryEF = new Hashtable();
        public IRepositoryEF<T> GetRepository<T>() where T : class
        {
            var type = typeof(T).Name;
            if (repositoryEF.ContainsKey(type))
            {
                return (IRepositoryEF<T>)repositoryEF[type];
            }
            var instance = new RepositoryEF<T>(_context);
            repositoryEF.Add(type, instance);
            return instance;
        }
        private IBaoCaoRepositoryEF _baoCaoRepositoryEF { get; set; }
        public IBaoCaoRepositoryEF baoCaoRepositoryEF
        {
            get
            {
                if (_baoCaoRepositoryEF == null)
                {
                    _baoCaoRepositoryEF = new BaoCaoRepositoryEF(_context);
                }
                return _baoCaoRepositoryEF;
            }
        }
        #endregion
    }
}
