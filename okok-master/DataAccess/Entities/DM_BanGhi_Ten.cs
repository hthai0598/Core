using BCDT.Core.Constants;
using DataAccess.Config;
using System;

namespace BCDT.Core.Entities
{
    public class DM_BanGhi_Ten : BaseEntity
    {
        public string TenBanGhi { get; set; }
        public string MaBanGhi { get; set; }
        public Guid? BanGhiId { get; set; }
        public Guid? DonViId { get; set; }
        public CommonStatus TrangThai { get; set; }
    }
}
