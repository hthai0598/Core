using DataAccess.Interface;
using Microsoft.EntityFrameworkCore.Storage;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using UnitOfWork.Dapper.IRepository;
using UnitOfWork.Dapper.Repository;

namespace UnitOfWork.Dapper
{
    public class UnitOfWorkDapper : IUnitOfWorkDapper
    {
        readonly IApplicationDbContext _context;
        IDbContextTransaction _transaction = null;
        public UnitOfWorkDapper(IApplicationDbContext context)
        {
            _context = context;
        }
        IDbContextTransaction IUnitOfWorkDapper.Transaction
        {
            get { return _transaction; }
        }
        public void Begin()
        {
            _transaction = _context.Database.BeginTransaction();
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
        private Hashtable repositoryDapper = new Hashtable();
        public IRepositoryDapper<T> GetRepository<T>() where T : class
        {
            var type = typeof(T).Name;
            if (repositoryDapper.ContainsKey(type))
            {
                return (IRepositoryDapper<T>)repositoryDapper[type];
            }
            var instance = new RepositoryDapper<T>(_context);
            repositoryDapper.Add(type, instance);
            return instance;
        }

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
