using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesAndExtensibility
{
    public class DbMigrator
    {
        public void Migrate()
        {
            Console.WriteLine("Migration started at {0}", DateTime.Now);
            Console.WriteLine("Migration finished at {0}", DateTime.Now);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
