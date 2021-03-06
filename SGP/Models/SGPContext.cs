using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace SGP.Models
{
    public partial class SGPContext : DbContext
    {
        public SGPContext()
        {
        }

        public SGPContext(DbContextOptions<SGPContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Entrevistum> Entrevista { get; set; }
        public virtual DbSet<Genero> Generos { get; set; }
        public virtual DbSet<Homologacion> Homologacions { get; set; }
        public virtual DbSet<Modulo> Modulos { get; set; }
        public virtual DbSet<Pago> Pagos { get; set; }
        public virtual DbSet<Programa> Programas { get; set; }
        public virtual DbSet<ProgramaUsuario> ProgramaUsuarios { get; set; }
        public virtual DbSet<Programacion> Programacions { get; set; }
        public virtual DbSet<Rol> Rols { get; set; }
        public virtual DbSet<TipoDocumento> TipoDocumentos { get; set; }
        public virtual DbSet<Usuario> Usuarios { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=DESKTOP-8BRUE8S\\SQLEXPRESS;Database=SGP;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "Modern_Spanish_CI_AS");

            modelBuilder.Entity<Entrevistum>(entity =>
            {
                entity.HasKey(e => e.IdEntrevista)
                    .HasName("PK__Entrevis__EE6CE9C7CF28E7B8");

                entity.Property(e => e.Estado)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FechaEntrevista).HasColumnType("date");

                entity.HasOne(d => d.IdUsuarioNavigation)
                    .WithMany(p => p.Entrevista)
                    .HasForeignKey(d => d.IdUsuario)
                    .HasConstraintName("FK__Entrevist__IdUsu__46E78A0C");
            });

            modelBuilder.Entity<Genero>(entity =>
            {
                entity.HasKey(e => e.IdGenero)
                    .HasName("PK__Genero__0F834988CD759434");

                entity.ToTable("Genero");

                entity.Property(e => e.ValGenero)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Homologacion>(entity =>
            {
                entity.HasKey(e => e.IdHomologacion)
                    .HasName("PK__Homologa__C7746319EE6414DC");

                entity.ToTable("Homologacion");

                entity.Property(e => e.FechaHomologacion).HasColumnType("date");

                entity.Property(e => e.Universidad)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdModuloNavigation)
                    .WithMany(p => p.Homologacions)
                    .HasForeignKey(d => d.IdModulo)
                    .HasConstraintName("FK__Homologac__IdMod__5070F446");

                entity.HasOne(d => d.IdProgramaNavigation)
                    .WithMany(p => p.Homologacions)
                    .HasForeignKey(d => d.IdPrograma)
                    .HasConstraintName("FK__Homologac__IdPro__4F7CD00D");

                entity.HasOne(d => d.IdUsuarioNavigation)
                    .WithMany(p => p.Homologacions)
                    .HasForeignKey(d => d.IdUsuario)
                    .HasConstraintName("FK__Homologac__IdUsu__5165187F");
            });

            modelBuilder.Entity<Modulo>(entity =>
            {
                entity.HasKey(e => e.IdModulo)
                    .HasName("PK__Modulo__D9F153157E172A35");

                entity.ToTable("Modulo");

                entity.Property(e => e.ValModulo)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdProgramaNavigation)
                    .WithMany(p => p.Modulos)
                    .HasForeignKey(d => d.IdPrograma)
                    .HasConstraintName("FK__Modulo__IdProgra__4CA06362");
            });

            modelBuilder.Entity<Pago>(entity =>
            {
                entity.HasKey(e => e.IdPago)
                    .HasName("PK__Pagos__FC851A3A3DEE69C7");

                entity.Property(e => e.ComprobantePago)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Fecha).HasColumnType("date");

                entity.HasOne(d => d.IdUsuarioNavigation)
                    .WithMany(p => p.Pagos)
                    .HasForeignKey(d => d.IdUsuario)
                    .HasConstraintName("FK__Pagos__IdUsuario__49C3F6B7");
            });

            modelBuilder.Entity<Programa>(entity =>
            {
                entity.HasKey(e => e.IdPrograma)
                    .HasName("PK__Programa__AF94ECA5693AED8E");

                entity.ToTable("Programa");

                entity.Property(e => e.Pensum)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ValPrograma)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ProgramaUsuario>(entity =>
            {
                entity.HasKey(e => e.IdProgramaUsuario)
                    .HasName("PK__Programa__A45CB108B5DC5313");

                entity.ToTable("ProgramaUsuario");

                entity.HasOne(d => d.IdProgramaNavigation)
                    .WithMany(p => p.ProgramaUsuarios)
                    .HasForeignKey(d => d.IdPrograma)
                    .HasConstraintName("FK__ProgramaU__IdPro__3E52440B");
            });

            modelBuilder.Entity<Programacion>(entity =>
            {
                entity.HasKey(e => e.IdProgramacion)
                    .HasName("PK__Programa__74E652C04A4440C2");

                entity.ToTable("Programacion");

                entity.Property(e => e.FechaFin).HasColumnType("date");

                entity.Property(e => e.FechaInicio).HasColumnType("date");

                entity.Property(e => e.Salon)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Semestre)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdModuloNavigation)
                    .WithMany(p => p.Programacions)
                    .HasForeignKey(d => d.IdModulo)
                    .HasConstraintName("FK__Programac__IdMod__5441852A");
            });

            modelBuilder.Entity<Rol>(entity =>
            {
                entity.HasKey(e => e.IdRol)
                    .HasName("PK__Rol__2A49584C6A574998");

                entity.ToTable("Rol");

                entity.Property(e => e.ValRol)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TipoDocumento>(entity =>
            {
                entity.HasKey(e => e.IdTipoDoc)
                    .HasName("PK__TipoDocu__08119E684F416C31");

                entity.ToTable("TipoDocumento");

                entity.Property(e => e.ValTipoDoc)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Usuario>(entity =>
            {
                entity.HasKey(e => e.IdUsuario)
                    .HasName("PK__Usuario__5B65BF97B93F6073");

                entity.ToTable("Usuario");

                entity.Property(e => e.Apellido)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Direccion)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Documento)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Email)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Nombre)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Pw)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.HasOne(d => d.GeneroNavigation)
                    .WithMany(p => p.Usuarios)
                    .HasForeignKey(d => d.Genero)
                    .HasConstraintName("FK__Usuario__Genero__412EB0B6");

                entity.HasOne(d => d.IdProgramaNavigation)
                    .WithMany(p => p.Usuarios)
                    .HasForeignKey(d => d.IdPrograma)
                    .HasConstraintName("FK__Usuario__IdProgr__4316F928");

                entity.HasOne(d => d.RolNavigation)
                    .WithMany(p => p.Usuarios)
                    .HasForeignKey(d => d.Rol)
                    .HasConstraintName("FK__Usuario__Rol__440B1D61");

                entity.HasOne(d => d.TipoDocNavigation)
                    .WithMany(p => p.Usuarios)
                    .HasForeignKey(d => d.TipoDoc)
                    .HasConstraintName("FK__Usuario__TipoDoc__4222D4EF");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
