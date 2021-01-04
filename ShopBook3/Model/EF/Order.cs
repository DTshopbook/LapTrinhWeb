namespace Model.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Order
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Order()
        {
            OrdersDetails = new HashSet<OrdersDetail>();
        }

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

        public bool Status { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OrdersDetail> OrdersDetails { get; set; }
    }
}
