using DataAccess.Interface;
using System.Data;
using UnitOfWork.Dapper.IRepository;
using UnitOfWork.Dapper.Repository;

namespace UnitOfWork.Dapper
{
    public class UnitOfWorkDapper : IUnitOfWorkDapper
    {
        readonly IApplicationDbContext _context;
        IDbTransaction _transaction = null;
        public UnitOfWorkDapper(IApplicationDbContext context)
        {
            _context = context;
        }

        IDbTransaction IUnitOfWorkDapper.Transaction
        {
            get { return _transaction; }
        }

        public void Begin()
        {
            _transaction = _context.Connection.BeginTransaction();
            Dispose();
        }

        public void Commit()
        {
            _transaction.Commit();
            Dispose();
        }

        public void Rollback()
        {
            _transaction.Rollback();
            Dispose();
        }

        public void Dispose()
        {
            if (_transaction != null)
                _transaction.Dispose();
            _transaction = null;
        }
        #region register
        private IBaoCaoRepositoryDapper _baoCaoRepositoryDapper;
        public IBaoCaoRepositoryDapper baoCaoRepositoryDapper
        {
            get
            {
                if (_baoCaoRepositoryDapper == null)
                {
                    _baoCaoRepositoryDapper = new BaoCaoRepositoryDapper(_context);
                }
                return _baoCaoRepositoryDapper;
            }
        }
        #endregion

    }
}
