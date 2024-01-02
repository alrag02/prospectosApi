using Microsoft.EntityFrameworkCore;

namespace prospectosApi.DataConnection
{
    public class DataConnection : DbContext
    {
        public DataConnection(DbContextOptions<DataConnection> dbContextOptions): base(dbContextOptions)    
        {

        }

        public DbSet<Models.Prospectos> prospectos { get; set; }
    }
}
