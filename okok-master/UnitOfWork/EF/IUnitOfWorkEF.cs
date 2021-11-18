using System.Threading.Tasks;
using UnitOfWork.EF.IRepository;

namespace UnitOfWork.UnitOfWork.Interface
{
    public interface IUnitOfWorkEF<T> where T : class
    {
        IBaoCaoRepositoryEF baoCaoRepositoryEF { get; }
        IRepositoryEF<T> repositoryEF { get; }
        Task<int> CommitAsync();
        int Commit();
    }
}
