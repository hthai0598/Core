using DataAccess.Config;
using System;

namespace BCDT.Core.Entities
{
    public class CT_BanGhi : BaseEntity
    {
        public Guid? ChiTieuId { get; set; }
        public Guid? BanGhiId { get; set; }
    }
}
