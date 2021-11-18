using BCDT.Core.Entities;
using DataAccess.Interface;
using Microsoft.EntityFrameworkCore;
using System.Data;

namespace BCDT.Core.Data
{
    public class ApplicationDbContext : DbContext, IApplicationDbContext
    {
        public IDbConnection Connection => Database.GetDbConnection();
        public DbSet<DanhMuc> DanhMuc { get; set; }
        public DbSet<CT_BanGhi> CT_BanGhi { get; set; }
        public DbSet<DM_BanGhi> DM_BanGhi { get; set; }
        public DbSet<DonVi_DanhMuc> DonVi_DanhMuc { get; set; }
        public DbSet<NhomChiTieu> NhomChiTieu { get; set; }
        public DbSet<NhomCT_ChiTieu> NhomCT_ChiTieu { get; set; }
        public DbSet<BaoCao> BaoCao { get; set; }
        public DbSet<BaoCao_BieuMau> BaoCao_BieuMau { get; set; }
        public DbSet<BieuMau> BieuMau { get; set; }
        public DbSet<BieuMau_ThanhPhan> BieuMau_ChiTieu { get; set; }
        public DbSet<DM_BanGhi_Ten> DM_BanGhi_Ten { get; set; }
        public DbSet<PhanQuyen_BC_BM> PQ_BC_BM { get; set; }
        public DbSet<BaoCao_DonVi> BaoCao_DonVi { get; set; }
        public DbSet<BC_DV_BieuMau> BC_DV_BieuMau { get; set; }
        public DbSet<BC_DV_DuLieu> BC_DV_DuLieu { get; set; }
        public DbSet<DonVi_BanGhi> DonVi_BanGhi { get; set; }
        public DbSet<DonViTinh> DonViTinh { get; set; }
        public DbSet<BC_DV_Histories> BC_DV_Histories { get; set; }
        public DbSet<KyBaoCao> KyBaoCao { get; set; }
        public DbSet<KyDuLieu> KyDuLieu { get; set; }
        public DbSet<CongThuc> CongThuc { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }
    }
}