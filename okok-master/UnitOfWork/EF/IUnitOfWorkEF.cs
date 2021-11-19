using System.Threading.Tasks;
using UnitOfWork.EF.IRepository;

namespace UnitOfWork.UnitOfWork.Interface
{
    public interface IUnitOfWorkEF
    {
        IBaoCaoRepositoryEF baoCaoRepositoryEF { get; }
        IRepositoryEF<T> GetRepository<T>() where T : class;
        Task<int> CommitAsync();
        int Commit();
    }
}
