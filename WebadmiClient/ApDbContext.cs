
using System.Data.Entity;
using WebadmiClient.Models;

namespace WebadmiClient
{
    public class ApDbContext : DbContext
    {
        public DbSet<Clientes> ModelsClients { get; set; }
        public DbSet<MovimientoCuenta> MovimientoCuenta { get; set; }


        
        public ApDbContext():base("name=DefaultConnection")
        {
            
        }

    }
}