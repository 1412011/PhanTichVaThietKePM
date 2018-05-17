namespace DTO
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("BOMON")]
    public partial class BOMON
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public BOMON()
        {
            GIAOVIENs = new HashSet<GIAOVIEN>();
            MON_LOP = new HashSet<MON_LOP>();
        }

        [Key]
        public int maBoMon { get; set; }

        [StringLength(50)]
        public string tenMonHoc { get; set; }

        public int? soTietHoc { get; set; }

        public int? heSoMon { get; set; }

        public int? truongBoMon { get; set; }

        public virtual GIAOVIEN GIAOVIEN { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<GIAOVIEN> GIAOVIENs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MON_LOP> MON_LOP { get; set; }
    }
}
