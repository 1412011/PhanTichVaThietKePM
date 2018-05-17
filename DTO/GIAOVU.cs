namespace DTO
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("GIAOVU")]
    public partial class GIAOVU
    {
        [StringLength(50)]
        public string vaiTro { get; set; }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int maNguoiDung { get; set; }

        public virtual NGUOIDUNG NGUOIDUNG { get; set; }
    }
}
