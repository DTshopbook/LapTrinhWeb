namespace ShopBookDbContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CHITIETDONHANG")]
    public partial class CHITIETDONHANG
    {
        [Key]
        [StringLength(10)]
        public string MaSach { get; set; }

        [StringLength(10)]
        public string MaDonDatHang { get; set; }

        public int? SLDat_hang { get; set; }

        public int? DonGia { get; set; }
    }
}
