using Microsoft.EntityFrameworkCore;
using prospectosApi.Models;

namespace prospectosApi.DataConnection
{
    public class DataConnection : DbContext
    { 
        public DataConnection(DbContextOptions<DataConnection> dbContextOptions): base(dbContextOptions)    
        {

        }

        public DbSet<Models.Prospectos> prospectos { get; set; }

        public DbSet<prospectosApi.Models.Documentos> Documentos { get; set; }
    }
}
