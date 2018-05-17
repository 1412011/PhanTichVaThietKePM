namespace DTO
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class QLHS : DbContext
    {
        public QLHS()
            : base("name=QLHS")
        {
        }

        public virtual DbSet<BANGDIEM> BANGDIEMs { get; set; }
        public virtual DbSet<BOMON> BOMONs { get; set; }
        public virtual DbSet<DIACHI> DIACHIs { get; set; }
        public virtual DbSet<GIAOVIEN> GIAOVIENs { get; set; }
        public virtual DbSet<GIAOVU> GIAOVUs { get; set; }
        public virtual DbSet<HANHKIEM> HANHKIEMs { get; set; }
        public virtual DbSet<HOCKY> HOCKies { get; set; }
        public virtual DbSet<HOCLUC> HOCLUCs { get; set; }
        public virtual DbSet<HOCSINH> HOCSINHs { get; set; }
        public virtual DbSet<KETQUACANAM> KETQUACANAMs { get; set; }
        public virtual DbSet<KETQUAHOCTAP> KETQUAHOCTAPs { get; set; }
        public virtual DbSet<KHOILOP> KHOILOPs { get; set; }
        public virtual DbSet<LOP> LOPs { get; set; }
        public virtual DbSet<LOP_HOCSINH> LOP_HOCSINH { get; set; }
        public virtual DbSet<MON_LOP> MON_LOP { get; set; }
        public virtual DbSet<NAMHOC> NAMHOCs { get; set; }
        public virtual DbSet<NGUOIDUNG> NGUOIDUNGs { get; set; }
        public virtual DbSet<QUYDINH> QUYDINHs { get; set; }
        public virtual DbSet<THOIKHOABIEU> THOIKHOABIEUx { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<BOMON>()
                .HasMany(e => e.GIAOVIENs)
                .WithRequired(e => e.BOMON)
                .HasForeignKey(e => e.monDay)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOMON>()
                .HasMany(e => e.MON_LOP)
                .WithOptional(e => e.BOMON)
                .HasForeignKey(e => e.maMon);

            modelBuilder.Entity<DIACHI>()
                .HasMany(e => e.NGUOIDUNGs)
                .WithOptional(e => e.DIACHI1)
                .HasForeignKey(e => e.diaChi);

            modelBuilder.Entity<GIAOVIEN>()
                .HasMany(e => e.BOMONs)
                .WithOptional(e => e.GIAOVIEN)
                .HasForeignKey(e => e.truongBoMon);

            modelBuilder.Entity<GIAOVIEN>()
                .HasMany(e => e.LOPs)
                .WithOptional(e => e.GIAOVIEN)
                .HasForeignKey(e => e.giaoVienCN);

            modelBuilder.Entity<GIAOVIEN>()
                .HasMany(e => e.MON_LOP)
                .WithOptional(e => e.GIAOVIEN)
                .HasForeignKey(e => e.giaoVienPhuTrach);

            modelBuilder.Entity<HANHKIEM>()
                .HasMany(e => e.KETQUACANAMs)
                .WithOptional(e => e.HANHKIEM1)
                .HasForeignKey(e => e.hanhKiem);

            modelBuilder.Entity<HANHKIEM>()
                .HasMany(e => e.KETQUAHOCTAPs)
                .WithOptional(e => e.HANHKIEM1)
                .HasForeignKey(e => e.hanhKiem);

            modelBuilder.Entity<HOCKY>()
                .HasMany(e => e.KETQUAHOCTAPs)
                .WithOptional(e => e.HOCKY1)
                .HasForeignKey(e => e.hocKy);

            modelBuilder.Entity<HOCLUC>()
                .HasMany(e => e.KETQUACANAMs)
                .WithOptional(e => e.HOCLUC1)
                .HasForeignKey(e => e.hocLuc);

            modelBuilder.Entity<HOCLUC>()
                .HasMany(e => e.KETQUAHOCTAPs)
                .WithOptional(e => e.HOCLUC1)
                .HasForeignKey(e => e.hocLuc);

            modelBuilder.Entity<KETQUAHOCTAP>()
                .HasMany(e => e.KETQUACANAMs)
                .WithOptional(e => e.KETQUAHOCTAP)
                .HasForeignKey(e => e.ketQuaHKI);

            modelBuilder.Entity<KETQUAHOCTAP>()
                .HasMany(e => e.KETQUACANAMs1)
                .WithOptional(e => e.KETQUAHOCTAP1)
                .HasForeignKey(e => e.ketQuaHKII);

            modelBuilder.Entity<KHOILOP>()
                .HasMany(e => e.LOPs)
                .WithOptional(e => e.KHOILOP1)
                .HasForeignKey(e => e.khoiLop);

            modelBuilder.Entity<LOP>()
                .Property(e => e.tenLop)
                .IsFixedLength();

            modelBuilder.Entity<LOP>()
                .Property(e => e.namHoc)
                .IsFixedLength();

            modelBuilder.Entity<LOP_HOCSINH>()
                .HasMany(e => e.KETQUACANAMs)
                .WithOptional(e => e.LOP_HOCSINH)
                .HasForeignKey(e => e.maHocSinh);

            modelBuilder.Entity<LOP_HOCSINH>()
                .HasMany(e => e.KETQUAHOCTAPs)
                .WithOptional(e => e.LOP_HOCSINH)
                .HasForeignKey(e => e.maHocSinh);

            modelBuilder.Entity<MON_LOP>()
                .HasMany(e => e.BANGDIEMs)
                .WithOptional(e => e.MON_LOP1)
                .HasForeignKey(e => e.mon_lop);

            modelBuilder.Entity<NAMHOC>()
                .Property(e => e.tenNamHoc)
                .IsFixedLength();

            modelBuilder.Entity<NAMHOC>()
                .HasMany(e => e.LOPs)
                .WithOptional(e => e.NAMHOC1)
                .HasForeignKey(e => e.namHoc);

            modelBuilder.Entity<NGUOIDUNG>()
                .Property(e => e.sDT)
                .IsFixedLength();

            modelBuilder.Entity<NGUOIDUNG>()
                .Property(e => e.email)
                .IsFixedLength();

            modelBuilder.Entity<NGUOIDUNG>()
                .Property(e => e.taiKhoan)
                .IsFixedLength();

            modelBuilder.Entity<NGUOIDUNG>()
                .Property(e => e.matKhau)
                .IsFixedLength();

            modelBuilder.Entity<NGUOIDUNG>()
                .HasOptional(e => e.GIAOVIEN)
                .WithRequired(e => e.NGUOIDUNG);

            modelBuilder.Entity<NGUOIDUNG>()
                .HasOptional(e => e.GIAOVU)
                .WithRequired(e => e.NGUOIDUNG);
        }
    }
}
