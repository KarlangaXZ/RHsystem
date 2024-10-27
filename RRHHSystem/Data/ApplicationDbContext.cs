using Microsoft.EntityFrameworkCore;
using RRHHSystem.Models;

namespace RRHHSystem.Data
{
    public class ApplicationDbContext : DbContext
    {
        // Definición de DbSet para cada entidad
        public DbSet<User> Users { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Cargo> Cargos { get; set; }
        public DbSet<Ponche> Ponches { get; set; }
        public DbSet<WorkedHour> WorkedHours { get; set; }
        public DbSet<Nomina> Nominas { get; set; }
        public DbSet<Permiso> Permisos { get; set; }
        public DbSet<Account> Accounts { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<User>().HasData(new User
            {
                Id = 1,
                Username = "admin",
                PasswordHash = BCrypt.Net.BCrypt.HashPassword("admin123"),
                Role = "Admin"
            });

            // Configuración para la entidad Nomina
            modelBuilder.Entity<Nomina>()
                .Property(n => n.TotalDineroHorasExtras)
                .HasColumnType("decimal(18,2)");

            modelBuilder.Entity<Nomina>()
                .Property(n => n.Salario)
                .HasColumnType("decimal(18,2)");

            modelBuilder.Entity<Nomina>()
                .Property(n => n.TotalAPagar)
                .HasColumnType("decimal(18,2)");

            // Configuración para la entidad Employee
            modelBuilder.Entity<Employee>()
                .Property(e => e.PricePerHour)
                .HasColumnType("decimal(18,2)");

            modelBuilder.Entity<Cargo>()
                .Property(c => c.Salary)
                .HasColumnType("decimal(18,2)");
        }
    }
}
