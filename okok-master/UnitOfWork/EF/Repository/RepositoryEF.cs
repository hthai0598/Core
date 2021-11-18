using DataAccess.Interface;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using UnitOfWork.EF.IRepository;

namespace UnitOfWork.EF.Repository
{
    public class RepositoryEF<T> : IRepositoryEF<T> where T : class
    {
        readonly IApplicationDbContext context;
        protected DbSet<T> DbSet;
        public RepositoryEF(IApplicationDbContext _context)
        {
            this.context = _context;
            this.DbSet = context.Set<T>();
        }

        public void Add(T obj)
        {
            throw new NotImplementedException();
        }

        public Task<T> GetById(Guid id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<T>> GetAll()
        {
            var all = await DbSet.ToListAsync();
            return all.ToList();
        }

        public void Update(T obj)
        {
            throw new NotImplementedException();
        }

        public void Remove(Guid id)
        {
            throw new NotImplementedException();
        }

        public T GetSingle(Expression<Func<T, bool>> criteria)
        {
            throw new NotImplementedException();
        }

        public Task<T> GetSingleAsync(Expression<Func<T, bool>> criteria)
        {
            throw new NotImplementedException();
        }

        public Task<List<T>> GetListAsync(Expression<Func<T, bool>> criteria)
        {
            throw new NotImplementedException();
        }

        public List<T> GetList(Expression<Func<T, bool>> criteria)
        {
            throw new NotImplementedException();
        }

        public IQueryable<T> QueryAll()
        {
            throw new NotImplementedException();
        }

        public IQueryable<T> GetWhere(Expression<Func<T, bool>> criteria)
        {
            throw new NotImplementedException();
        }
    }
}
