using BCDT.Core.Constants;
using DataAccess.Config;
using System;

namespace BCDT.Core.Entities
{
    public class ChiTieu_Ten : BaseEntity
    {
        public string TenChiTieu { get; set; }
        public string MaChiTieu { get; set; }
        public Guid? ChiTieuId { get; set; }
        public Guid? DonViId { get; set; }
        public CommonStatus TrangThai { get; set; }
    }
}
