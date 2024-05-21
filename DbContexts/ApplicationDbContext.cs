using Microsoft.EntityFrameworkCore;

namespace final_exam;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options) { }

    public DbSet<Student> Students { get; set; }

    public DbSet<Class> Classes { get; set; }

    public DbSet<StudentClass> StudentClass { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) { }

    protected override void OnModelCreating(ModelBuilder modelBuilder) { 
        modelBuilder.Entity<StudentClass>().HasOne<Student>().WithMany().HasForeignKey(sc => sc.StudentId);
        modelBuilder.Entity<StudentClass>().HasOne<Class>().WithMany().HasForeignKey(sc => sc.ClassId);
    }
}
