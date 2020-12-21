namespace ShopBookDbContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class HOA_DON
    {
        [Key]
        [StringLength(10)]
        public string MaHD { get; set; }

        public DateTime? NgayLap { get; set; }

        public double? ThanhTien { get; set; }

        [StringLength(10)]
        public string MaKH { get; set; }

        [StringLength(50)]
        public string TenKH { get; set; }
    }
}
