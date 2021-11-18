using DataAccess.Config;
using System;

namespace BCDT.Core.Entities
{
    public class NhomCT_ChiTieu : BaseEntity
    {
        public Guid BanGhiId { get; set; }
        public Guid NhomChiTieuId { get; set; }
    }
}
