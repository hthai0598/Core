using System.Data;
using DataAccess.Interface;
using UnitOfWork.Dapper.IRepository;

namespace UnitOfWork.Dapper
{
    public interface IUnitOfWorkDapper<T> where T : class
    {
        IBaoCaoRepositoryDapper baoCaoRepositoryDapper { get; }
        IDbTransaction Transaction { get; }
        IRepositoryDapper<T> repositoryDapper { get; }
        void Begin();
        void Commit();
        void Rollback();
    }
}
