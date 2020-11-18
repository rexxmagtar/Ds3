using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace SOPSLab3Service.Models
{
    public class RegisterContext: DbContext
    {
        public DbSet<Service> Services { get; set; }
        public DbSet<Method> Methods { get; set; }

        public RegisterContext(DbContextOptions<RegisterContext> options)
            : base(options)
        {
            Database.EnsureCreated();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Service>()
                        .ToTable("Service");

            modelBuilder.Entity<Service>()
                        .Property(s => s.ServiceName)
                        .HasColumnName("Id");

            modelBuilder.Entity<Method>()
                        .Property(m => m.ServiceName)
                        .HasColumnName("ServiceId");

            modelBuilder.Entity<Service>()
                        .HasMany(s => s.AvailableMethods)
                        .WithOne()
                        .HasForeignKey(m => m.ServiceName);
        }
    }
}
