using DataAccess.Config;
using System;

namespace BCDT.Core.Entities
{
    public class DonVi_DanhMuc : BaseEntity
    {
        public Guid DanhMucId { get; set; }
        public Guid DonViId { get; set; }
    }
}
