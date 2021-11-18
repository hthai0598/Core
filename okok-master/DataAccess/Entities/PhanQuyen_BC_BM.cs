using DataAccess.Config;
using System;

namespace BCDT.Core.Entities
{
    public class PhanQuyen_BC_BM : BaseEntity
    {
        public Guid? BieuMauId { get; set; }
        public Guid? BaoCaoId { get; set; }
        public Guid? ChiTieuId { get; set; }
        public Guid? DonViId { get; set; }
        public Guid? CanBoId { get; set; }
        public Guid? BieuMau_ChiTieuId { get; set; }
        public bool Xem { get; set; }
        public bool NhapLieu { get; set; }
    }
}
