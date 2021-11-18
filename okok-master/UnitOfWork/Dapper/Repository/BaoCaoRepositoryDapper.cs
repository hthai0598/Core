using BCDT.Core.Entities;
using DataAccess.Interface;
using UnitOfWork.Dapper.IRepository;

namespace UnitOfWork.Dapper.Repository
{
    public class BaoCaoRepositoryDapper : RepositoryDapper<BaoCao>, IBaoCaoRepositoryDapper
    {
        public BaoCaoRepositoryDapper(IApplicationDbContext context) : base(context)
        {
        }
    }
}
