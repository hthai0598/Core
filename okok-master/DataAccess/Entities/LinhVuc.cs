using BCDT.Core.Constants;
using DataAccess.Config;
using System;

namespace BCDT.Core.Entities
{
    public class LinhVuc : BaseEntity
    {
        public Guid TenLinhVuc { get; set; }
        public string MaLinhVuc { get; set; }
        public string MoTa { get; set; }
        public Guid? DonViQuanLyID { get; set; }
        public Guid? LinhVucChaId { get; set; }
        public CommonStatus TrangThai { get; set; }
    }
}
