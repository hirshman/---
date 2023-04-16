using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace PersonalAria.Data
{
    public partial class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext()
        {
        }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Documents> Documents { get; set; }
        public virtual DbSet<DocumentTypes> DocumentTypes { get; set; }
        public virtual DbSet<V_Document> V_Documents { get; set; }
        public virtual DbSet<TableTest1> TableTest1 { get; set; }
        public virtual DbSet<TableTest2> TableTest2 { get; set; }
        public virtual DbSet<TableTestsR1> TableTestsR1 { get; set; }
        public virtual DbSet<TableTestsR2> TableTestsR2 { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                //#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                //                optionsBuilder.UseSqlServer("Server=(local)\\sqlexpress;Database=LaborSystems;Trusted_Connection=True;MultipleActiveResultSets=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "Hebrew_CI_AS");

            modelBuilder.Entity<Documents>(entity =>
            {
                entity.Property(e => e.Comments)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.CreationDate).HasColumnType("datetime");

                entity.Property(e => e.ExpiredDate).HasColumnType("datetime");

                entity.Property(e => e.FormContents).HasColumnType("xml");

                entity.Property(e => e.StatusDate).HasColumnType("datetime");

                entity.HasOne(d => d.Type)
                    .WithMany(p => p.Documents)
                    .HasForeignKey(d => d.TypeId)
                    .HasConstraintName("FK_Documents_DocumentTypes");
            });

            modelBuilder.Entity<DocumentTypes>(entity =>
            {
                entity.Property(e => e.ApplicationCode)
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.BuslogicCommand)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.BuslogicObject)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.ClassPrefix)
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.Code)
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.Description).IsUnicode(false);

                entity.Property(e => e.EngName)
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.Icon)
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.IsActive).HasDefaultValueSql("((1))");

                entity.Property(e => e.Name)
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.Path)
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TableTest1>(entity =>
            {
                entity.Property(e => e.Name)
                   .HasMaxLength(50)
                   .IsUnicode(false);
            });

            modelBuilder.Entity<TableTest2>(entity =>
            {
                entity.Property(e => e.Name)
                   .HasMaxLength(50)
                   .IsUnicode(false);
            });

            modelBuilder.Entity<TableTestsR1>(entity =>
            {
                entity.Property(e => e.Name)
                   .HasMaxLength(50)
                   .IsUnicode(false);

                entity.Property(e => e.Description)
                  .HasMaxLength(50)
                  .IsUnicode(false);

                entity.Property(e => e.IsActive)
                  .HasDefaultValue(true);

                entity.Property(e => e.CreationDate)
                  .HasColumnType("datetime");

            });

            modelBuilder.Entity<TableTestsR2>(entity =>
            {
                entity.Property(e => e.Name)
                   .HasMaxLength(50)
                   .IsUnicode(false);
            });

            //modelBuilder.Entity<V_Document>(entity =>
            //{
            //    entity.HasNoKey();

            //    entity.ToView("V_Documents");

            //    entity.Property(e => e.Comments)
            //        .HasMaxLength(255)
            //        .IsUnicode(false);

            //    entity.Property(e => e.CreationDate).HasColumnType("datetime");

            //    entity.Property(e => e.ExpiredDate).HasColumnType("datetime");

            //    entity.Property(e => e.FormContents).HasColumnType("xml");

            //    entity.Property(e => e.Name)
            //        .HasMaxLength(60)
            //        .IsUnicode(false);

            //    entity.Property(e => e.StatusDate).HasColumnType("datetime");
            //});

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
