
using DataAccess.Interface;
using DataAccess.Config;
using System.Threading.Tasks;
using UnitOfWork.Mongo.IRepository;
using UnitOfWork.Mongo.Repository;
using System.Collections.Generic;
using BCDT.Core.Entities;
using System.Linq;
using System.Collections;

namespace UnitOfWork.UnitOfWork
{
    public class UnitOfWorkMongo : IUnitOfWorkMongo
    {
        public IMongoContext _context;
        public UnitOfWorkMongo(IMongoContext context)
        {
            _context = context;
        }
        public async Task<bool> CommitAsync()
        {
            var changeAmount = await _context.SaveChangesAsync();
            return changeAmount > 0;
        }
        public bool Commit()
        {
            return _context.SaveChanges() > 0;
        }
        public void Dispose()
        {
            _context.Dispose();
        }

        #region Register
        private Hashtable repositoryMongo = new Hashtable();
        public IRepositoryMongo<T> GetRepository<T>() where T : class
        {
            var type = typeof(T).Name;
            if (repositoryMongo.ContainsKey(type))
            {
                return (IRepositoryMongo<T>)repositoryMongo[type];
            }
            var instance = new RepositoryMongo<T>(_context);
            repositoryMongo.Add(type, instance);
            return instance;
        }

        IRepositoryBaoCaoMongo _baoCaoRepositoryMongo;
        public IRepositoryBaoCaoMongo baoCaoRepositoryMongo
        {
            get
            {
                if (_baoCaoRepositoryMongo == null)
                    _baoCaoRepositoryMongo = new RepositoryBaoCaoMongo(_context);

                return _baoCaoRepositoryMongo;
            }
        }
        #endregion

    }
}
