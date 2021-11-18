using System;
using System.Threading.Tasks;
using UnitOfWork.Mongo.IRepository;

namespace UnitOfWork.UnitOfWork
{
    public interface IUnitOfWorkMongo : IDisposable
    {
        IRepositoryBaoCaoMongo baoCaoRepositoryMongo { get; }
        Task<bool> CommitAsync();
        bool Commit();
    }
}
