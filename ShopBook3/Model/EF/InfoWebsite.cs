namespace Model.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("InfoWebsite")]
    public partial class InfoWebsite
    {
        [Key]
        [StringLength(50)]
        public string Webname { get; set; }

        [StringLength(10)]
        public string WebPhone { get; set; }

        [StringLength(1000)]
        public string WebAddress { get; set; }

        [StringLength(250)]
        public string WebEmail { get; set; }
    }
}
