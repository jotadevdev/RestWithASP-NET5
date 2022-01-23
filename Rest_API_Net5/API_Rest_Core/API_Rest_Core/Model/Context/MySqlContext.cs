using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema; 

namespace API_Rest_Core.Model.Context
{
    public class MySqlContext : DbContext
    {
        public MySqlContext()
        {

        }

        public MySqlContext(DbContextOptions<MySqlContext> options) : base(options)  
        {

        }

        public DbSet<Person> People { get; set; }

    }
}
