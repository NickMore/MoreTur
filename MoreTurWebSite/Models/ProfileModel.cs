namespace MoreTurWebSite.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class ProfileModel : DbContext
    {
        public ProfileModel()
            : base("name=DefaultConnection")
        {
        }

        public virtual DbSet<Profile> Profiles { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Profile>()
                .Property(e => e.Birthday)
                .IsFixedLength();
        }
    }
}
