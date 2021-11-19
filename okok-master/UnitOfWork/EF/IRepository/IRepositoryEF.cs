using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace UnitOfWork.EF.IRepository
{
    public interface IRepositoryEF<T> : IDisposable
    {
        Task<IEnumerable<T>> GetAll();
    }
}
