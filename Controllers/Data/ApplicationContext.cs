using CrudApplication.Models;
using Microsoft.EntityFrameworkCore;

namespace CrudApplication.Controllers.Data
{
    public class ApplicationContext:DbContext
    {
        public ApplicationContext(DbContextOptions<ApplicationContext>option) : base(option){ }
        public DbSet<Employee> Employees { get; set; }

    }
}
