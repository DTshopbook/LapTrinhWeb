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
        [StringLength(50)]
        public string ProductID { get; set; }

        [StringLength(50)]
        public string NameBook { get; set; }

        [StringLength(50)]
        public string WriterID { get; set; }

        [StringLength(50)]
        public string NxbID { get; set; }

        public double? Price { get; set; }

        public int? Amount { get; set; }

        [StringLength(50)]
        public string ImageID { get; set; }

        [StringLength(50)]
        public string CategoryID { get; set; }

        [StringLength(1000)]
        public string Describe { get; set; }

        
        public bool Status { get; set; }
    }
}
