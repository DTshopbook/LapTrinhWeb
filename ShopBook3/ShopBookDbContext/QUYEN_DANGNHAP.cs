namespace ShopBookDbContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class QUYEN_DANGNHAP
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int MaQuyen { get; set; }

        [StringLength(50)]
        public string TenQuyen { get; set; }
    }
}
