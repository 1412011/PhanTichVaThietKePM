namespace DTO
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("THOIKHOABIEU")]
    public partial class THOIKHOABIEU
    {
        [Key]
        public int maTKB { get; set; }

        public int? maMon_Lop { get; set; }

        public int? tietTrongNgay { get; set; }

        public int? ngayTrongTuan { get; set; }

        public virtual MON_LOP MON_LOP { get; set; }
    }
}
