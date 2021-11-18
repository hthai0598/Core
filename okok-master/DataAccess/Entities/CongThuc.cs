using DataAccess.Config;

namespace BCDT.Core.Entities
{
    public class CongThuc : BaseEntity
    {
        public string MaCongThuc { get; set; }
        public string TenCongThuc { get; set; }
        public string NoiDung { get; set; }
    }
}
