using DataAccess.Config;
using System;

namespace BCDT.Core.Entities
{
    public class BaoCao_DonVi : BaseEntity
    {
        public Guid? BaoCaoId { get; set; }
        public DateTime? KyBaoCao { get; set; }
        public Guid? BC_DV_ChaId { get; set; }
        public Guid? DonViGiaoId { get; set; }
        public Guid? CanBoGiaoId { get; set; }
        public Guid? KyBaoCaoId { get; set; }
        public Guid? KyDuLieuId { get; set; }
        public Guid? DonViNhanId { get; set; }
        public Guid? CanBoNhanId { get; set; }
        public DateTime? NgayGiaoBao { get; set; }
        public DateTime? HanNhapBaoCao { get; set; }
        public bool CaNhan { get; set; }
        public int TrangThai { get; set; }
    }
}
