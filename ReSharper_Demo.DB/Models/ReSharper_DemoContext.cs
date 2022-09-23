using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;

namespace ReSharper_Demo.DB.Models
{
    public partial class ReSharper_DemoContext : DbContext
    {
        public ReSharper_DemoContext()
        {
        }

        public ReSharper_DemoContext(DbContextOptions<ReSharper_DemoContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Employee> Employees { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=ReSharper_Demo;Trusted_Connection=False;Integrated Security=True");
            }
            optionsBuilder.LogTo(Console.WriteLine, LogLevel.Information);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employee>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
