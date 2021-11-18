
using BCDT.Core.Constants;
using DataAccess.Config;

namespace BCDT.Core.Entities
{
    public class NhomChiTieu : BaseEntity
    {
        public string MaNhom { get; set; }
        public string TenNhom { get; set; }
        public string MoTa { get; set; }
        public NhomCT_TrangThaiConst TrangThai { get; set; }
    }
}
