namespace GurupithWebApi.Entity
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class GurupithEntities : DbContext
    {
        public GurupithEntities()
            : base("name=GurupithEntities")
        {
        }

        public virtual DbSet<personal_information> personal_information { get; set; }
        public virtual DbSet<tblreg> tblregs { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<personal_information>()
                .Property(e => e.nameofperson)
                .IsUnicode(false);

            modelBuilder.Entity<personal_information>()
                .Property(e => e.addressofcorrespondance)
                .IsUnicode(false);

            modelBuilder.Entity<personal_information>()
                .Property(e => e.city)
                .IsUnicode(false);

            modelBuilder.Entity<personal_information>()
                .Property(e => e.districy)
                .IsUnicode(false);

            modelBuilder.Entity<personal_information>()
                .Property(e => e.state)
                .IsUnicode(false);

            modelBuilder.Entity<personal_information>()
                .Property(e => e.country)
                .IsUnicode(false);

            modelBuilder.Entity<personal_information>()
                .Property(e => e.mobileno)
                .IsUnicode(false);

            modelBuilder.Entity<personal_information>()
                .Property(e => e.landlineno)
                .IsUnicode(false);

            modelBuilder.Entity<personal_information>()
                .Property(e => e.emailid)
                .IsUnicode(false);

            modelBuilder.Entity<personal_information>()
                .Property(e => e.occupation)
                .IsUnicode(false);

            modelBuilder.Entity<personal_information>()
                .Property(e => e.education)
                .IsUnicode(false);

            modelBuilder.Entity<personal_information>()
                .Property(e => e.anuualmember)
                .IsUnicode(false);

            modelBuilder.Entity<personal_information>()
                .Property(e => e.intensivelocation)
                .IsUnicode(false);

            modelBuilder.Entity<personal_information>()
                .Property(e => e.areofzone)
                .IsUnicode(false);

            modelBuilder.Entity<personal_information>()
                .Property(e => e.zonalhead)
                .IsUnicode(false);

            modelBuilder.Entity<personal_information>()
                .Property(e => e.zonalheadcontact)
                .IsUnicode(false);

            modelBuilder.Entity<personal_information>()
                .Property(e => e.designation)
                .IsUnicode(false);

            modelBuilder.Entity<personal_information>()
                .Property(e => e.status)
                .IsUnicode(false);
        }
    }
}
