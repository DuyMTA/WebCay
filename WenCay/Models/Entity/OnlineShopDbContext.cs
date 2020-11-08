namespace WenCay.Models.Entity
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class OnlineShopDbContext : DbContext
    {
        public OnlineShopDbContext()
            : base("name=OnlineShopDbContext")
        {
        }

        public virtual DbSet<ADMIN> ADMINs { get; set; }
        public virtual DbSet<BAIVIET> BAIVIETs { get; set; }
        public virtual DbSet<FeedBack> FeedBacks { get; set; }
        public virtual DbSet<GIOHANG> GIOHANGs { get; set; }
        public virtual DbSet<HOADON> HOADONs { get; set; }
        public virtual DbSet<HOADON_CHITIET> HOADON_CHITIET { get; set; }
        public virtual DbSet<KHACHHANG> KHACHHANGs { get; set; }
        public virtual DbSet<SANPHAM> SANPHAMs { get; set; }
        public virtual DbSet<THELOAI> THELOAIs { get; set; }
        public virtual DbSet<DanhMucSanPham> DanhMucSanPhams { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ADMIN>()
                .Property(e => e.Ten)
                .IsUnicode(false);

            modelBuilder.Entity<ADMIN>()
                .Property(e => e.Login)
                .IsUnicode(false);

            modelBuilder.Entity<ADMIN>()
                .Property(e => e.Password)
                .IsUnicode(false);

            modelBuilder.Entity<BAIVIET>()
                .Property(e => e.MaBV)
                .IsUnicode(false);

            modelBuilder.Entity<FeedBack>()
                .Property(e => e.ID)
                .IsUnicode(false);

            modelBuilder.Entity<FeedBack>()
                .Property(e => e.MaSP)
                .IsUnicode(false);

            modelBuilder.Entity<FeedBack>()
                .Property(e => e.IDKhachHang)
                .IsUnicode(false);

            modelBuilder.Entity<GIOHANG>()
                .Property(e => e.MaKH)
                .IsUnicode(false);

            modelBuilder.Entity<GIOHANG>()
                .Property(e => e.MaSP)
                .IsUnicode(false);

            modelBuilder.Entity<HOADON>()
                .Property(e => e.MaHD)
                .IsUnicode(false);

            modelBuilder.Entity<HOADON>()
                .Property(e => e.MaKH)
                .IsUnicode(false);

            modelBuilder.Entity<HOADON>()
                .HasMany(e => e.HOADON_CHITIET)
                .WithRequired(e => e.HOADON)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<HOADON_CHITIET>()
                .Property(e => e.MaHD)
                .IsUnicode(false);

            modelBuilder.Entity<HOADON_CHITIET>()
                .Property(e => e.MaSP)
                .IsUnicode(false);

            modelBuilder.Entity<KHACHHANG>()
                .Property(e => e.MaKH)
                .IsUnicode(false);

            modelBuilder.Entity<KHACHHANG>()
                .Property(e => e.Email)
                .IsUnicode(false);

            modelBuilder.Entity<KHACHHANG>()
                .Property(e => e.DienThoai)
                .IsUnicode(false);

            modelBuilder.Entity<KHACHHANG>()
                .HasMany(e => e.FeedBacks)
                .WithOptional(e => e.KHACHHANG)
                .HasForeignKey(e => e.IDKhachHang);

            modelBuilder.Entity<KHACHHANG>()
                .HasMany(e => e.GIOHANGs)
                .WithRequired(e => e.KHACHHANG)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<SANPHAM>()
                .Property(e => e.MaSP)
                .IsUnicode(false);

            modelBuilder.Entity<SANPHAM>()
                .HasMany(e => e.GIOHANGs)
                .WithRequired(e => e.SANPHAM)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<SANPHAM>()
                .HasMany(e => e.HOADON_CHITIET)
                .WithRequired(e => e.SANPHAM)
                .WillCascadeOnDelete(false);
        }
    }
}
