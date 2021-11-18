using DataAccess.Config;
using System;

namespace BCDT.Core.Entities
{
    public class BaoCao_BieuMau : BaseEntity
    {
        public Guid? BieuMauId { get; set; }
        public Guid? BaoCaoId { get; set; }
    }
}
