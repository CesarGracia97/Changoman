using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using ArticulosTecnologicos.Shared.Models;

#nullable disable

namespace ArticulosTecnologicos.Server.Models
{
    public partial class ArticulosContext : DbContext
    {
        public ArticulosContext()
        {
        }

        public ArticulosContext(DbContextOptions<ArticulosContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Informacion> Informacions { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            /*if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=DESKTOP-614H9OV; Database=Articulos; Trusted_Connection=True; User=sa; Password=win+alt+r;");
            }*/
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "Modern_Spanish_CI_AS");

            modelBuilder.Entity<Informacion>(entity =>
            {
                entity.ToTable("Informacion");
                entity.HasKey(e => e.Id);

                entity.Property(e => e.Detalles)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Precio).HasColumnType("money");
                
                entity.Property(e => e.Stock)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
