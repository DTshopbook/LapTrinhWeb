namespace ShopBookDbContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TACGIA")]
    public partial class TACGIA
    {
        [Key]
        [StringLength(10)]
        public string MaTG { get; set; }

        [Required]
        [StringLength(30)]
        public string TenTG { get; set; }
    }
}
