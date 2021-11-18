using DataAccess.Config;
using System;

namespace BCDT.Core.Entities
{
    public class BC_BM_DonVi : BaseEntity
    {
        public Guid? BaoCaoId { get; set; }
        public Guid? BieuMauId { get; set; }
        public Guid? DonViId { get; set; }
        public Guid? BC_BM_Id { get; set; }
    }
}
