﻿using DataAccess.Interface;
using System.Data;
using UnitOfWork.Dapper.IRepository;
using UnitOfWork.Dapper.Repository;

namespace UnitOfWork.Dapper
{
    public class UnitOfWorkDapper<T> : IUnitOfWorkDapper<T> where T : class
    {
        readonly IApplicationDbContext _context;
        IDbTransaction _transaction = null;
        IDbConnection _connection;
        public UnitOfWorkDapper(IApplicationDbContext context)
        {
            _context = context;
            _connection = _context.Connection;
        }

        IDbTransaction IUnitOfWorkDapper<T>.Transaction
        {
            get { return _transaction; }
        }

        public void Begin()
        {
            _transaction = _connection.BeginTransaction();
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
        private IRepositoryDapper<T> _repositoryDapper;
        public IRepositoryDapper<T> repositoryDapper
        {
            get
            {
                if (_repositoryDapper == null)
                {
                    _repositoryDapper = new RepositoryDapper<T>(_context);
                }
                return _repositoryDapper;
            }
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
