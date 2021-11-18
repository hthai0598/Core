using DataAccess.Config;
using System;

namespace BCDT.Core.Entities
{
    public class BaoCao : BaseEntity
    {
        public string MaBaoCao { get; set; }
        public string TenBaoCao { get; set; }
        public Guid? KyBaoCaoId { get; set; }
        public Guid? LinhVucId { get; set; }
        public Guid? CheDoId { get; set; }
        public int TrangThai { get; set; }
    }
}
