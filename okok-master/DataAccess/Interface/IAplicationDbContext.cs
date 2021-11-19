using BCDT.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using System;
using System.Data;
using System.Threading;
using System.Threading.Tasks;

namespace DataAccess.Interface
{
    public interface IApplicationDbContext : IDisposable
    {
        public IDbConnection Connection { get; }
        public DatabaseFacade Database { get; }
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

        DbSet<TEntity> Set<TEntity>() where TEntity : class;
        int SaveChanges();
        Task<int> SaveChangesAsync(CancellationToken cancellationToken = default(CancellationToken));
    }
}
