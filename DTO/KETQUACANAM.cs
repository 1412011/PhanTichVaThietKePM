namespace DTO
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("KETQUACANAM")]
    public partial class KETQUACANAM
    {
        [Key]
        public int maKetQua { get; set; }

        public int? ketQuaHKI { get; set; }

        public int? ketQuaHKII { get; set; }

        public double? diemTrungBinh { get; set; }

        public int? maHocSinh { get; set; }

        public int? xepHang { get; set; }

        [StringLength(100)]
        public string nhanXet { get; set; }

        [StringLength(10)]
        public string hanhKiem { get; set; }

        [StringLength(10)]
        public string hocLuc { get; set; }

        public virtual HANHKIEM HANHKIEM1 { get; set; }

        public virtual HOCLUC HOCLUC1 { get; set; }

        public virtual KETQUAHOCTAP KETQUAHOCTAP { get; set; }

        public virtual KETQUAHOCTAP KETQUAHOCTAP1 { get; set; }

        public virtual LOP_HOCSINH LOP_HOCSINH { get; set; }
    }
}
