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
        public async Task<IEnumerable<T>> GetAll()
        {
            var all = await DbSet.ToListAsync();
            return all.ToList();
        }

    }
}
