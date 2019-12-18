using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Sisdef.Web.Razor.Domains
{
    public partial class SisdefContext : DbContext
    {
        public SisdefContext()
        {
        }

        public SisdefContext(DbContextOptions<SisdefContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Defeito> Defeito { get; set; }
        public virtual DbSet<Equipamento> Equipamento { get; set; }
        public virtual DbSet<RegistroDefeito> RegistroDefeito { get; set; }
        public virtual DbSet<TipoEquipamento> TipoEquipamento { get; set; }
        public virtual DbSet<Usuario> Usuario { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=.\\SqlExpress; Initial Catalog=SISDEF; user id=sa; pwd=info132");

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Defeito>(entity =>
            {
                entity.ToTable("DEFEITO");

                entity.HasIndex(e => e.Nome)
                    .HasName("UQ__DEFEITO__E2AB1FF45CB47B15")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Nome)
                    .IsRequired()
                    .HasColumnName("NOME")
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Equipamento>(entity =>
            {
                entity.ToTable("EQUIPAMENTO");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.DataCadastro).HasColumnName("DATA_CADASTRO");

                entity.Property(e => e.TipoEquipamentoId).HasColumnName("TIPO_EQUIPAMENTO_ID");

                entity.HasOne(d => d.TipoEquipamento)
                    .WithMany(p => p.Equipamento)
                    .HasForeignKey(d => d.TipoEquipamentoId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__EQUIPAMEN__TIPO___74AE54BC");
            });

            modelBuilder.Entity<RegistroDefeito>(entity =>
            {
                entity.ToTable("REGISTRO_DEFEITO");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.DataProblema)
                    .HasColumnName("DATA_PROBLEMA")
                    .HasColumnType("datetime");

                entity.Property(e => e.DefeitoId).HasColumnName("DEFEITO_ID");

                entity.Property(e => e.EquipamentoId).HasColumnName("EQUIPAMENTO_ID");

                entity.Property(e => e.HoraFinal).HasColumnName("HORA_FINAL");

                entity.Property(e => e.HoraInicio).HasColumnName("HORA_INICIO");

                entity.HasOne(d => d.Defeito)
                    .WithMany(p => p.RegistroDefeito)
                    .HasForeignKey(d => d.DefeitoId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__REGISTRO___DEFEI__7C4F7684");

                entity.HasOne(d => d.Equipamento)
                    .WithMany(p => p.RegistroDefeito)
                    .HasForeignKey(d => d.EquipamentoId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__REGISTRO___EQUIP__7B5B524B");
            });

            modelBuilder.Entity<TipoEquipamento>(entity =>
            {
                entity.ToTable("TIPO_EQUIPAMENTO");

                entity.HasIndex(e => e.Nome)
                    .HasName("UQ__TIPO_EQU__E2AB1FF453E047AB")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Nome)
                    .IsRequired()
                    .HasColumnName("NOME")
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Usuario>(entity =>
            {
                entity.ToTable("USUARIO");

                entity.HasIndex(e => e.Email)
                    .HasName("UQ__USUARIO__161CF72481CF6BE0")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasColumnName("EMAIL")
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.Senha)
                    .IsRequired()
                    .HasColumnName("SENHA")
                    .HasMaxLength(150)
                    .IsUnicode(false);
            });
        }
    }
}
