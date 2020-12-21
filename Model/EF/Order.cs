namespace Model.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Order
    {
        public int OrderID { get; set; }

        public DateTime? CreateDate { get; set; }

        [StringLength(50)]
        public string UserRealName { get; set; }

        [StringLength(200)]
        public string UserAddress { get; set; }

        [StringLength(10)]
        public string UserPhone { get; set; }

        [StringLength(100)]
        public string UserEmail { get; set; }

        public bool? Status { get; set; }

        
    }
}
