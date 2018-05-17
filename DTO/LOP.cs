namespace DTO
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("LOP")]
    public partial class LOP
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public LOP()
        {
            LOP_HOCSINH = new HashSet<LOP_HOCSINH>();
            MON_LOP = new HashSet<MON_LOP>();
        }

        [Key]
        public int maLop { get; set; }

        [StringLength(10)]
        public string tenLop { get; set; }

        public int? siSo { get; set; }

        public int? giaoVienCN { get; set; }

        [StringLength(10)]
        public string khoiLop { get; set; }

        [StringLength(10)]
        public string namHoc { get; set; }

        public virtual GIAOVIEN GIAOVIEN { get; set; }

        public virtual KHOILOP KHOILOP1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LOP_HOCSINH> LOP_HOCSINH { get; set; }

        public virtual NAMHOC NAMHOC1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MON_LOP> MON_LOP { get; set; }
    }
}
