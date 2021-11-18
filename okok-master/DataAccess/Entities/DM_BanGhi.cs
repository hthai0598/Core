using BCDT.Core.Constants;
using DataAccess.Config;
using System;

namespace BCDT.Core.Entities
{
    public class DM_BanGhi : BaseEntity
    {
        public string TenBanGhi { get; set; }
        public string MaBanGhi { get; set; }
        public Guid? DanhMucId { get; set; }
        public Guid? BanGhiChaId { get; set; }
        public Guid? DonViQuanLyId { get; set; }
        public Guid? LinhVucId { get; set; }
        public CT_KieuConstants Kieu { get; set; }
    }
}
