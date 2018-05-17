namespace DTO
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("BANGDIEM")]
    public partial class BANGDIEM
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public BANGDIEM()
        {
            KETQUAHOCTAPs = new HashSet<KETQUAHOCTAP>();
        }

        [Key]
        public int maBangDiem { get; set; }

        public double? diemMieng { get; set; }

        public double? diem15p { get; set; }

        public double? diemTiet { get; set; }

        public int? mon_lop { get; set; }

        public virtual MON_LOP MON_LOP1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<KETQUAHOCTAP> KETQUAHOCTAPs { get; set; }
    }
}
