namespace DTO
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("QUYDINH")]
    public partial class QUYDINH
    {
        [Key]
        public int maQuyDinh { get; set; }

        [StringLength(100)]
        public string tenQuyDinh { get; set; }

        [StringLength(20)]
        public string kieu { get; set; }

        [StringLength(20)]
        public string giaTri { get; set; }

        public bool? tinhTrang { get; set; }
    }
}
