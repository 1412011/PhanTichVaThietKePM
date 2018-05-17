namespace DTO
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("NGUOIDUNG")]
    public partial class NGUOIDUNG
    {
        [Key]
        public int maNguoiDung { get; set; }

        [StringLength(60)]
        public string tenNguoiDung { get; set; }

        [StringLength(4)]
        public string gioiTinh { get; set; }

        [Column(TypeName = "date")]
        public DateTime? ngaySinh { get; set; }

        [StringLength(15)]
        public string sDT { get; set; }

        public int? diaChi { get; set; }

        [StringLength(60)]
        public string email { get; set; }

        [StringLength(50)]
        public string taiKhoan { get; set; }

        [StringLength(50)]
        public string matKhau { get; set; }

        public virtual DIACHI DIACHI1 { get; set; }

        public virtual GIAOVIEN GIAOVIEN { get; set; }

        public virtual GIAOVU GIAOVU { get; set; }
    }
}
