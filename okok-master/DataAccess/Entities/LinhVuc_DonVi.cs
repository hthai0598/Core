using DataAccess.Config;
using System;

namespace BCDT.Core.Entities
{
    class LinhVuc_DonVi : BaseEntity
    {
        public Guid? LinhVucId { get; set; }
        public Guid? DonViApDungId { get; set; }
    }
}
