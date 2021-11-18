using DataAccess.Config;
using System;

namespace BCDT.Core.Entities
{
    public class BC_DV_DuLieu : BaseEntity
    {
        public Guid BaoCaoId { get; set; }
        public Guid BC_DV_BM_Id { get; set; }
        public Guid CotId { get; set; }
        public Guid HangId { get; set; }
        public string GiaTri { get; set; }
        public string CongThuc { get; set; }
        public string DonViTinh { get; set; }
        public string KyHieu { get; set; }
    }
}
