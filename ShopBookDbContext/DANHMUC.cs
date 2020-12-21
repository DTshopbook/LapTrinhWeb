namespace ShopBookDbContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DANHMUC")]
    public partial class DANHMUC
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DANHMUC()
        {
            DANHMUC1 = new HashSet<DANHMUC>();
        }

        [Key]
        [StringLength(10)]
        public string MaDM { get; set; }

        [StringLength(50)]
        public string TenDM { get; set; }

        [StringLength(100)]
        public string Image_Daidien { get; set; }

        public int? ThuTu { get; set; }

        [StringLength(10)]
        public string MaDMCha { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DANHMUC> DANHMUC1 { get; set; }

        public virtual DANHMUC DANHMUC2 { get; set; }
    }
}
