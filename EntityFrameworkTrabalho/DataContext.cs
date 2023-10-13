using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkTrabalho
{
    public class DataContext : DbContext
    {
        public DataContext() : base("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Teste;Integrated Security=True;Connect Timeout=30;Encrypt=False") 
        { }

        public DbSet<Pessoa> pessoas { get; set; }

    }
}
