using DataAccess.Config;
using System;

namespace BCDT.Core.Entities
{
    public class BC_DV_Histories : BaseEntity
    {
        public string OldValue { get; set; }
        public bool NewValue { get; set; }
        public Guid? BC_DV_DL_Id { get; set; }
        public Guid? DonViId { get; set; }
    }
}
