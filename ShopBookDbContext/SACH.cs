namespace ShopBookDbContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SACH")]
    public partial class SACH
    {
        [Key]
        [StringLength(10)]
        public string MaSach { get; set; }

        [Required]
        [StringLength(50)]
        public string TenSach { get; set; }

        [StringLength(50)]
        public string TacGia { get; set; }

        [StringLength(50)]
        public string Nxb { get; set; }

        public int? GiaSach { get; set; }

        [StringLength(200)]
        public string NoiDung { get; set; }

        public int SoTrang { get; set; }

        public int SLSach { get; set; }

        public int? SLConlai { get; set; }
    }
}
