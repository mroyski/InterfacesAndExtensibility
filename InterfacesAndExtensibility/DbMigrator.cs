using System;

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
}
