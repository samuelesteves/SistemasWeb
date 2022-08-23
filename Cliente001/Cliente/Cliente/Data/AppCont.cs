using Cliente.Models;
using Microsoft.EntityFrameworkCore;

namespace Cliente.Data
{
    public class AppCont : DbContext
    {
        public AppCont(DbContextOptions<AppCont> options) : base(options)
        {

        }

        public DbSet<Cli> Clientes { get; set; }
    }
}
