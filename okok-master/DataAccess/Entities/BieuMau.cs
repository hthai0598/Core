
using DataAccess.Config;

namespace BCDT.Core.Entities
{
    public class BieuMau : BaseEntity
    {
        public string MaBieuMau { get; set; }
        public string TenBieuMau { get; set; }
        public bool DVTHang { get; set; }
        public string DVTCot { get; set; }
    }
}
