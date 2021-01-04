namespace Model.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class User
    {
        [Key]
        [StringLength(50)]
        public string Username { get; set; }

        [StringLength(50)]
        public string Pasword { get; set; }

        public int? Rank { get; set; }

        public bool Statuss { get; set; }

        public DateTime? CreateDate { get; set; }

        [StringLength(50)]
        public string Email { get; set; }
    }
}
