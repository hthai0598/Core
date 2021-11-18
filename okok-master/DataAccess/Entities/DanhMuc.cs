using BCDT.Core.Constants;
using DataAccess.Config;
using System;

namespace BCDT.Core.Entities
{
    public class DanhMuc : BaseEntity
    {
        public string TenDanhMuc { get; set; }
        public string MaDanhMuc { get; set; }
        public string MoTa { get; set; }
        public DanhMucConstants TrangThai { get; set; }
        public DMKieuEnum Kieu { get; set; }
        public Guid? DonViQuanLyId { get; set; }
        public Guid? DanhMucChaId { get; set; }
    }
}
