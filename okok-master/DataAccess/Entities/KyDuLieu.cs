using DataAccess.Config;
using System;

namespace BCDT.Core.Entities
{
    public class KyDuLieu : BaseEntity
    {
        public string TenKyDuLieu { get; set; }
        public DateTime? TuNgay { get; set; }
        public DateTime? DenNgay { get; set; }
        public int TrangThai { get; set; }
        public Guid KyBaoCaoId { get; set; }
    }
}
