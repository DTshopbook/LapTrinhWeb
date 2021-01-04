namespace Model.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("OrdersDetail")]
    public partial class OrdersDetail
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int OrderID { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(50)]
        public string ProductID { get; set; }

        public int Amount { get; set; }

        public double Total { get; set; }

        public virtual Order Order { get; set; }

        public virtual Product Product { get; set; }
    }
}
