
using DataAccess.Interface;
using System;
using System.Threading.Tasks;
using UnitOfWork.Mongo.IRepository;
using UnitOfWork.Mongo.Repository;

namespace UnitOfWork.UnitOfWork
{
    public class UnitOfWorkMongo : IUnitOfWorkMongo
    {
        private readonly IMongoContext _context;
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
    }
}
