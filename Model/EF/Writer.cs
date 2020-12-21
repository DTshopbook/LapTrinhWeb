namespace Model.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Writer")]
    public partial class Writer
    {
        [StringLength(50)]
        public string WriterID { get; set; }

        [StringLength(50)]
        public string WriterName { get; set; }
    }
}
