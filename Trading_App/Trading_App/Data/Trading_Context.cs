using Microsoft.EntityFrameworkCore;
using Trading_App.Models;

namespace Trading_App.Data
{
    public class Trading_Context:DbContext
    {
        //Bridge between the database and the Model
        public Trading_Context(DbContextOptions<Trading_Context>options):base(options) { }

        public DbSet<Trade_Model> Trades { get; set; }
    }
}
//Data Source=LAPTOP-SVJ4OCSP;Initial Catalog=Trade_Db;Integrated Security=True;Pooling=False;Encrypt=False;Trust Server Certificate=True
