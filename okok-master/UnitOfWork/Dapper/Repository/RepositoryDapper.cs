using Dapper;
using DataAccess.Interface;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace UnitOfWork.Dapper
{
    public class RepositoryDapper<T> : IRepositoryDapper<T> where T : class
    {
        private readonly IApplicationDbContext context;
        public RepositoryDapper(IApplicationDbContext context)
        {
            this.context = context;
        }
        public async Task<int> ExecuteAsync(string sql, object param = null, IDbTransaction transaction = null, CancellationToken cancellationToken = default)
        {
            return await context.Connection.ExecuteAsync(sql, param, transaction);
        }
        public async Task<IReadOnlyList<T>> QueryAsync(string sql, object param = null, IDbTransaction transaction = null, CancellationToken cancellationToken = default)
        {
            return (await context.Connection.QueryAsync<T>(sql, param, transaction)).AsList();
        }
        public async Task<T> QueryFirstOrDefaultAsync(string sql, object param = null, IDbTransaction transaction = null, CancellationToken cancellationToken = default)
        {
            return await context.Connection.QueryFirstOrDefaultAsync<T>(sql, param, transaction);
        }
        public async Task<T> QuerySingleAsync(string sql, object param = null, IDbTransaction transaction = null, CancellationToken cancellationToken = default)
        {
            return await context.Connection.QuerySingleAsync<T>(sql, param, transaction);
        }

        public async Task Execute(string sp, DynamicParameters parms, CommandType commandType = CommandType.StoredProcedure)
        {
            await context.Connection.ExecuteAsync(sp, parms, commandType: commandType);
        }

        public T Get(string sp, DynamicParameters parms, CommandType commandType = CommandType.StoredProcedure)
        {
            return context.Connection.Query<T>(sp, parms, commandType: commandType).FirstOrDefault();
        }

        public async Task<T> GetAsync(string sp, DynamicParameters parms, CommandType commandType = CommandType.StoredProcedure)
        {
            return await context.Connection.QueryFirstOrDefaultAsync<T>(sp, parms, commandType: commandType);
        }

        public List<T> GetAll(string sp, DynamicParameters parms, CommandType commandType = CommandType.StoredProcedure)
        {
            var item = context.Connection.Query<T>(sp, parms, commandType: commandType).ToList();
            return item;
        }

        public IEnumerable<T> GetAllItem(string sp, DynamicParameters parms, CommandType commandType = CommandType.StoredProcedure)
        {
            var item = context.Connection.Query<T>(sp, parms, commandType: commandType);
            return item;
        }

        public async Task<IEnumerable<T>> GetAllAsync(string sp, DynamicParameters parms, CommandType commandType = CommandType.StoredProcedure)
        {
            return await context.Connection.QueryAsync<T>(sp, parms, commandType: commandType);
        }

        public async Task<int> Execute_int(string sp, DynamicParameters parms, CommandType commandType = CommandType.StoredProcedure)
        {
            return await context.Connection.ExecuteAsync(sp, parms, commandType: commandType);
        }
    }
}
