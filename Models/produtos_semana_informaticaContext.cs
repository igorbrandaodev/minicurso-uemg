using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace projeto_mini_curso.Models
{
    public partial class produtos_semana_informaticaContext : DbContext
    {
        public produtos_semana_informaticaContext()
        {
        }

        public produtos_semana_informaticaContext(DbContextOptions<produtos_semana_informaticaContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Produto> Produtos { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=produtos_semana_informatica;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<Produto>(entity =>
            {
                entity.ToTable("produtos");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Descricao)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("descricao");

                entity.Property(e => e.Nome)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("nome");

                entity.Property(e => e.Preco)
                    .HasColumnType("decimal(10, 2)")
                    .HasColumnName("preco");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
