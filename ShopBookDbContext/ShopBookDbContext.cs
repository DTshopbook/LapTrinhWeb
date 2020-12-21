namespace ShopBookDbContext
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class ShopBookDbContext : DbContext
    {
        public ShopBookDbContext()
            : base("name=ShopBookDbContext")
        {
        }

        public virtual DbSet<DANGKY> DANGKies { get; set; }
        public virtual DbSet<DANHMUC> DANHMUCs { get; set; }
        public virtual DbSet<DON_DAT_HANG> DON_DAT_HANG { get; set; }
        public virtual DbSet<HOA_DON> HOA_DON { get; set; }
        public virtual DbSet<NHOM_SAN_PHAM> NHOM_SAN_PHAM { get; set; }
        public virtual DbSet<NXB> NXBs { get; set; }
        public virtual DbSet<QUYEN_DANGNHAP> QUYEN_DANGNHAP { get; set; }
        public virtual DbSet<SACH> SACHes { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<TACGIA> TACGIAs { get; set; }
        public virtual DbSet<CHITIETDONHANG> CHITIETDONHANGs { get; set; }
        public virtual DbSet<User> Users { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<DANGKY>()
                .Property(e => e.GioiTinh)
                .IsFixedLength();

            modelBuilder.Entity<DANHMUC>()
                .Property(e => e.MaDM)
                .IsFixedLength();

            modelBuilder.Entity<DANHMUC>()
                .Property(e => e.MaDMCha)
                .IsFixedLength();

            modelBuilder.Entity<DANHMUC>()
                .HasMany(e => e.DANHMUC1)
                .WithOptional(e => e.DANHMUC2)
                .HasForeignKey(e => e.MaDMCha);

            modelBuilder.Entity<DON_DAT_HANG>()
                .Property(e => e.MaDonDatHang)
                .IsFixedLength();

            modelBuilder.Entity<DON_DAT_HANG>()
                .Property(e => e.MaKH)
                .IsFixedLength();

            modelBuilder.Entity<DON_DAT_HANG>()
                .Property(e => e.Sdt)
                .IsFixedLength();

            modelBuilder.Entity<HOA_DON>()
                .Property(e => e.MaHD)
                .IsFixedLength();

            modelBuilder.Entity<HOA_DON>()
                .Property(e => e.MaKH)
                .IsFixedLength();

            modelBuilder.Entity<NHOM_SAN_PHAM>()
                .Property(e => e.NhomID)
                .IsFixedLength();

            modelBuilder.Entity<NXB>()
                .Property(e => e.MaNXB)
                .IsFixedLength();

            modelBuilder.Entity<SACH>()
                .Property(e => e.MaSach)
                .IsFixedLength();

            modelBuilder.Entity<TACGIA>()
                .Property(e => e.MaTG)
                .IsFixedLength();

            modelBuilder.Entity<CHITIETDONHANG>()
                .Property(e => e.MaSach)
                .IsFixedLength();

            modelBuilder.Entity<CHITIETDONHANG>()
                .Property(e => e.MaDonDatHang)
                .IsFixedLength();
        }
    }
}
