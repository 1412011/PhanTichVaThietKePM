namespace DTO
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DIACHI")]
    public partial class DIACHI
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DIACHI()
        {
            NGUOIDUNGs = new HashSet<NGUOIDUNG>();
        }

        [Key]
        public int maDiaChi { get; set; }

        [StringLength(10)]
        public string soNha { get; set; }

        [StringLength(50)]
        public string duong { get; set; }

        [StringLength(50)]
        public string xa { get; set; }

        [StringLength(50)]
        public string huyen { get; set; }

        [StringLength(50)]
        public string tinh { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<NGUOIDUNG> NGUOIDUNGs { get; set; }
    }
}
