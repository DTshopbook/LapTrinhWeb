namespace ShopBookDbContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("NXB")]
    public partial class NXB
    {
        [Key]
        [StringLength(10)]
        public string MaNXB { get; set; }

        [StringLength(30)]
        public string TenNXB { get; set; }

        [StringLength(50)]
        public string DiaChi_NXB { get; set; }
    }
}
