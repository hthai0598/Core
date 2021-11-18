using BCDT.Core.Constants;
using DataAccess.Config;
using System;

namespace BCDT.Core.Entities
{
    public class BieuMau_ThanhPhan : BaseEntity
    {
        public Guid? BieuMauId { get; set; }
        public Guid? ChiTieuId { get; set; }
        public Guid? BanGhiId { get; set; }
        public Guid? BM_CT_ChaId { get; set; }
        public Guid? DonViId { get; set; }
        public int SoHang { get; set; }
        public string MaChiTieu { get; set; }
        public string TenChiTieu { get; set; }
        public KieuHienThi Kieu { get; set; }

    }
}
