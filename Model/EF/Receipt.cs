namespace Model.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Receipt")]
    public partial class Receipt
    {
        [StringLength(50)]
        public string ReceiptID { get; set; }

        public DateTime? DateCreate { get; set; }

        [StringLength(50)]
        public string Username { get; set; }

        public double? PriceTotal { get; set; }

        public int? ProductAmount { get; set; }
    }
}
