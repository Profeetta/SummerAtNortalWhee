using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace WoWClasses.Model
{
    public partial class WoWClassesContext : DbContext
    {
        public WoWClassesContext()
        {
        }

        public WoWClassesContext(DbContextOptions<WoWClassesContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Classing> Classes { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=tcp:elenatuom.database.windows.net,1433;Initial Catalog=WorldOfInfotable;Persist Security Info=False;User ID=elkku;Password=Try12345;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<Classing>(entity =>
            {
                entity.HasKey(e => e.Idx)
                    .HasName("PK__classes__DC501A78D3779129");

                entity.Property(e => e.wowclass).IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
