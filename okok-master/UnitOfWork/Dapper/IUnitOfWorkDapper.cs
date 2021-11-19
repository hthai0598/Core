using System.Data;
using DataAccess.Interface;
using Microsoft.EntityFrameworkCore.Storage;
using UnitOfWork.Dapper.IRepository;

namespace UnitOfWork.Dapper
{
    public interface IUnitOfWorkDapper
    {
        IRepositoryDapper<T> GetRepository<T>() where T : class;
        IBaoCaoRepositoryDapper baoCaoRepositoryDapper { get; }
        IDbContextTransaction Transaction { get; }
        void Begin();
        void Commit();
        void Rollback();
    }
}
