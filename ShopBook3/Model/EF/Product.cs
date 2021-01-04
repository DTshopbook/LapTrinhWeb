namespace Model.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Product")]
    public partial class Product
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Product()
        {
            OrdersDetails = new HashSet<OrdersDetail>();
        }

        [StringLength(50)]
        public string ProductID { get; set; }

        [StringLength(50)]
        public string NameBook { get; set; }

        [StringLength(50)]
        public string WriterID { get; set; }

        [StringLength(50)]
        public string NxbID { get; set; }

        public double? Price { get; set; }

        public int Amount { get; set; }

        [StringLength(50)]
        public string ImageID { get; set; }

        [StringLength(50)]
        public string CategoryID { get; set; }

        [StringLength(1000)]
        public string Describe { get; set; }

        public bool Status { get; set; }

        public virtual Category Category { get; set; }

        public virtual Nxb Nxb { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OrdersDetail> OrdersDetails { get; set; }

        public virtual Writer Writer { get; set; }
    }
}
