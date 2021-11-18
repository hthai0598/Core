using BCDT.Core.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Bussiness.IService
{
    public interface IBaoCaoService
    {
        Task<IEnumerable<BaoCao>> GetAll();
    }
}
