namespace MoreTurWebSite.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Profile")]
    public partial class Profile
    {
        public int Id { get; set; }

        [Required]
        [StringLength(128)]
        public string UserId { get; set; }

        [StringLength(70)]
        public string Name { get; set; }

        [StringLength(10)]
        public string Birthday { get; set; }

        public string Photo { get; set; }

        public string City { get; set; }

        public string Description { get; set; }
    }
}
