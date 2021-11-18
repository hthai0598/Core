using DataAccess.Config;
using System;

namespace BCDT.Core.Entities
{
    public class DonVi_BanGhi : BaseEntity
    {
        public Guid BanGhiId { get; set; }
        public Guid DonViId { get; set; }
    }
}
