namespace De02
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tbl_SanPham
    {
        [Key]
        [StringLength(6)]
        public string MaSP { get; set; }

        [Required]
        [StringLength(30)]
        public string TenSP { get; set; }

        public DateTime NgayNhap { get; set; }

        [Required]
        [StringLength(2)]
        public string MaLoai { get; set; }

        public virtual tbl_LoaiSP tbl_LoaiSP { get; set; }
    }
}
