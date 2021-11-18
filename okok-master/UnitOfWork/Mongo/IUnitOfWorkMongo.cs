using System;
using System.Threading.Tasks;
using UnitOfWork.Mongo.IRepository;

namespace UnitOfWork.UnitOfWork
{
    public interface IUnitOfWorkMongo<T> : IDisposable where T : class
    {
        IRepositoryBaoCaoMongo baoCaoRepositoryMongo { get; }
        IRepositoryMongo<T> repositoryMongo { get; }
        Task<bool> CommitAsync();
        bool Commit();
    }
}
