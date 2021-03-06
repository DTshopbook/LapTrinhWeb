namespace Model.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Menu")]
    public partial class Menu
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int MenuID { get; set; }

        [StringLength(50)]
        public string Content { get; set; }

        [StringLength(50)]
        public string Link { get; set; }

        [StringLength(50)]
        public string Target { get; set; }

        public bool Status { get; set; }

        public int? TypeID { get; set; }
    }
}
