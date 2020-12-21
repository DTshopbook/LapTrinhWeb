namespace Model.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Nxb")]
    public partial class Nxb
    {
        [StringLength(50)]
        public string NxbID { get; set; }

        [StringLength(50)]
        public string NxbName { get; set; }

        [StringLength(100)]
        public string NxbAddress { get; set; }
    }
}
