using Microsoft.EntityFrameworkCore;
using TaskManagementSystem.Api.Models;

namespace TaskManagementSystem.Api.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Taskss> Tasks { get; set; }
        public DbSet<User> Users { get; set; }

        public DbSet<Report> Reports { get; set; } 
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<User>()
                .HasIndex(u => u.Email)
                .IsUnique();

            modelBuilder.Entity<Taskss>()
                .HasOne<User>()
                .WithMany()
                .HasForeignKey(t => t.AssignedToEmployeeId);
        }

    }
}
