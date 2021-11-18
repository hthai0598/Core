using BCDT.Core.Entities;
using DataAccess.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitOfWork.Mongo.IRepository;

namespace UnitOfWork.Mongo.Repository
{
    public class RepositoryBaoCaoMongo : RepositoryMongo<BaoCao>, IRepositoryBaoCaoMongo
    {
        public RepositoryBaoCaoMongo(IMongoContext context) : base(context)
        {
        }
    }
}
