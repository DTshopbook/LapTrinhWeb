namespace ShopBookDbContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class DON_DAT_HANG
    {
        [Key]
        [StringLength(10)]
        public string MaDonDatHang { get; set; }

        public DateTime? NgayTao { get; set; }

        public double? ThanhTien { get; set; }

        [StringLength(100)]
        public string TinhTrangDonHang { get; set; }

        [StringLength(10)]
        public string MaKH { get; set; }

        [StringLength(50)]
        public string TenKH { get; set; }

        [StringLength(10)]
        public string Sdt { get; set; }

        [StringLength(50)]
        public string EmailKH { get; set; }
    }
}
