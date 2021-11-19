using System;
using System.Threading.Tasks;
using UnitOfWork.Mongo.IRepository;

namespace UnitOfWork.UnitOfWork
{
    public interface IUnitOfWorkMongo : IDisposable
    {
        IRepositoryBaoCaoMongo baoCaoRepositoryMongo { get; }
        IRepositoryMongo<T> GetRepository<T>() where T : class;
        Task<bool> CommitAsync();
        bool Commit();
    }
}
