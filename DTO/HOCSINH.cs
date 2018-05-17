namespace DTO
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("HOCSINH")]
    public partial class HOCSINH
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public HOCSINH()
        {
            LOP_HOCSINH = new HashSet<LOP_HOCSINH>();
        }

        [Key]
        public int maHocSinh { get; set; }

        [StringLength(50)]
        public string hoTen { get; set; }

        [StringLength(5)]
        public string gioiTinh { get; set; }

        [Column(TypeName = "date")]
        public DateTime? ngaySinh { get; set; }

        [StringLength(50)]
        public string noiSinh { get; set; }

        [StringLength(60)]
        public string hoTenCha { get; set; }

        [StringLength(50)]
        public string ngheNghiepCha { get; set; }

        [StringLength(60)]
        public string hoTenMe { get; set; }

        [StringLength(50)]
        public string ngheNghiepMe { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LOP_HOCSINH> LOP_HOCSINH { get; set; }
    }
}
