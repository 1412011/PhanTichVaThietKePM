namespace DTO
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("HOCLUC")]
    public partial class HOCLUC
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public HOCLUC()
        {
            KETQUACANAMs = new HashSet<KETQUACANAM>();
            KETQUAHOCTAPs = new HashSet<KETQUAHOCTAP>();
        }

        [Key]
        [StringLength(10)]
        public string tenHocLuc { get; set; }

        public double? diemCanTren { get; set; }

        public double? diemCanDuoi { get; set; }

        public double? diemKhongChe { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<KETQUACANAM> KETQUACANAMs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<KETQUAHOCTAP> KETQUAHOCTAPs { get; set; }
    }
}
