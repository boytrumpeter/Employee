namespace EmployerInfrastructure
{
    using EmployerDomain.Entities;
    using Microsoft.EntityFrameworkCore;

    public class EmployeeDbContext : DbContext
    {
        public EmployeeDbContext()
        {

        }
        public EmployeeDbContext(DbContextOptions<EmployeeDbContext> options) : base(options)
        {
        }

        public virtual DbSet<Employee> Employees { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employee>()
                .HasData(
                new Employee { EmployeeId = 1, AccountNumber = "01234550", CreatedUTC = System.DateTime.Today, EmployeeName = "John" },
                new Employee { EmployeeId = 2, AccountNumber = "56264550", CreatedUTC = System.DateTime.Today, EmployeeName = "Pete" });
        }
    }
}
