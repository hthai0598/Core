using System.Threading.Tasks;
using UnitOfWork.EF.IRepository;

namespace UnitOfWork.UnitOfWork.Interface
{
    public interface IUnitOfWorkEF
    {
        IBaoCaoRepositoryEF baoCaoRepositoryEF { get; }
        Task<int> CommitAsync();
        int Commit();
    }
}
