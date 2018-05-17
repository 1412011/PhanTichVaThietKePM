namespace DTO
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class LOP_HOCSINH
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public LOP_HOCSINH()
        {
            KETQUACANAMs = new HashSet<KETQUACANAM>();
            KETQUAHOCTAPs = new HashSet<KETQUAHOCTAP>();
        }

        [Key]
        public int maLop_HS { get; set; }

        public int? sTT { get; set; }

        public int? maLop { get; set; }

        public int? maHocSinh { get; set; }

        public virtual HOCSINH HOCSINH { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<KETQUACANAM> KETQUACANAMs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<KETQUAHOCTAP> KETQUAHOCTAPs { get; set; }

        public virtual LOP LOP { get; set; }
    }
}
