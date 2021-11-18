using BCDT.Core.Constants;
using DataAccess.Config;
using System;

namespace BCDT.Core.Entities
{
    public class ChiTieu : BaseEntity
    {
        public string TenChiTieu { get; set; }
        public string MaChiTieu { get; set; }
        public Guid DonViQuanLyId { get; set; }
        public Guid DanhMucId { get; set; }
        public CT_KieuConstants Kieu { get; set; }
        public CT_TrangThaiConstants TrangThai { get; set; }
    }
}
