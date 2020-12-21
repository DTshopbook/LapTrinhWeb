namespace ShopBookDbContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class NHOM_SAN_PHAM
    {
        [Key]
        [StringLength(10)]
        public string NhomID { get; set; }

        [StringLength(50)]
        public string TenNhom { get; set; }

        [StringLength(100)]
        public string Image_Nhom { get; set; }

        public int? ThuTu { get; set; }

        public int? SoSPHienThi { get; set; }
    }
}
