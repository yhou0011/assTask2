namespace Task2.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class _5032_Modles : DbContext
    {
        public _5032_Modles()
            : base("name=FIT5032_Modles")
        {
        }

        public virtual DbSet<Activity> Activities { get; set; }
        public virtual DbSet<Reservation> Reservations { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Activity>()
                .HasMany(e => e.Reservations)
                .WithRequired(e => e.Activity)
                .WillCascadeOnDelete(false);
        }
    }
}
