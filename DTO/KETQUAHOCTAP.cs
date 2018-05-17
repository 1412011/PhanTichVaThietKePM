namespace DTO
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("KETQUAHOCTAP")]
    public partial class KETQUAHOCTAP
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public KETQUAHOCTAP()
        {
            KETQUACANAMs = new HashSet<KETQUACANAM>();
            KETQUACANAMs1 = new HashSet<KETQUACANAM>();
        }

        [Key]
        public int maKetQua { get; set; }

        public int? maBangDiem { get; set; }

        public double? diemThi { get; set; }

        public double? diemTrungBinh { get; set; }

        public int? thangTrongNam { get; set; }

        public int? maHocSinh { get; set; }

        public int? xepHang { get; set; }

        [StringLength(100)]
        public string nhanXet { get; set; }

        [StringLength(10)]
        public string hanhKiem { get; set; }

        [StringLength(10)]
        public string hocLuc { get; set; }

        public int? hocKy { get; set; }

        public int? loaiKetQua { get; set; }

        public virtual BANGDIEM BANGDIEM { get; set; }

        public virtual HANHKIEM HANHKIEM1 { get; set; }

        public virtual HOCKY HOCKY1 { get; set; }

        public virtual HOCLUC HOCLUC1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<KETQUACANAM> KETQUACANAMs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<KETQUACANAM> KETQUACANAMs1 { get; set; }

        public virtual LOP_HOCSINH LOP_HOCSINH { get; set; }
    }
}
