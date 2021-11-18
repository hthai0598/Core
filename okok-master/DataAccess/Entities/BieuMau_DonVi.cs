using DataAccess.Config;
using System;

namespace BCDT.Core.Entities
{
    public class BieuMau_DonVi : BaseEntity
    {
        public Guid BieuMauId { get; set; }
        public Guid DonViId { get; set; }
        public int KieuBaoCao { get; set; }
        public int LoaiTongHop { get; set; }
    }
}
