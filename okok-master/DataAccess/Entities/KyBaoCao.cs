using DataAccess.Config;

namespace BCDT.Core.Entities
{
    public class KyBaoCao : BaseEntity
    {
        public string MaKy { get; set; }
        public string TenKy { get; set; }
        public int TrangThai { get; set; }
    }
}
