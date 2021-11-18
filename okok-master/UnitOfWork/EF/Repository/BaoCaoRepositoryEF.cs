using BCDT.Core.Entities;
using DataAccess.Interface;
using UnitOfWork.EF.IRepository;

namespace UnitOfWork.EF.Repository
{
    public class BaoCaoRepositoryEF : RepositoryEF<BaoCao>, IBaoCaoRepositoryEF
    {
        public BaoCaoRepositoryEF(IApplicationDbContext context) : base(context)
        {
        }
    }
}
