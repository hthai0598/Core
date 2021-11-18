using System.Data;

namespace UnitOfWork.Dapper
{
    public interface IUnitOfWorkDapper
    {
        IDbTransaction Transaction { get; }
        void Begin();
        void Commit();
        void Rollback();
    }
}
