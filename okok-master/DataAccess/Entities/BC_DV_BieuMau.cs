using DataAccess.Config;
using System;

namespace BCDT.Core.Entities
{
    public class BC_DV_BieuMau : BaseEntity
    {
        public Guid? BC_DV_Id { get; set; }
        public Guid? BaoCaoId { get; set; }
        public Guid? BieuMauId { get; set; }
    }
}
