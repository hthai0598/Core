using Dapper;
using Microsoft.EntityFrameworkCore.Storage;
using System.Collections.Generic;
using System.Data;
using System.Threading;
using System.Threading.Tasks;

namespace DataAccess.Interface
{
    public interface IRepositoryDapper<T> where T : class
    {
        Task<IReadOnlyList<T>> QueryAsync(string sql, object param = null, IDbContextTransaction transaction = null, CancellationToken cancellationToken = default);
        Task<T> QueryFirstOrDefaultAsync(string sql, object param = null, IDbContextTransaction transaction = null, CancellationToken cancellationToken = default);
        Task<T> QuerySingleAsync(string sql, object param = null, IDbContextTransaction transaction = null, CancellationToken cancellationToken = default);
        Task<int> ExecuteAsync(string sql, object param = null, IDbContextTransaction transaction = null, CancellationToken cancellationToken = default);

        T Get(string sp, DynamicParameters parms, CommandType commandType = CommandType.StoredProcedure);
        Task<T> GetAsync(string sp, DynamicParameters parms, CommandType commandType = CommandType.StoredProcedure);
        List<T> GetAll(string sp, DynamicParameters parms, CommandType commandType = CommandType.StoredProcedure);
        IEnumerable<T> GetAllItem(string sp, DynamicParameters parms, CommandType commandType = CommandType.StoredProcedure);
        Task<IEnumerable<T>> GetAllAsync(string sp, DynamicParameters parms, CommandType commandType = CommandType.StoredProcedure);
        Task Execute(string sp, DynamicParameters parms, CommandType commandType = CommandType.StoredProcedure);
        Task<int> Execute_int(string sp, DynamicParameters parms, CommandType commandType = CommandType.StoredProcedure);
    }
}
