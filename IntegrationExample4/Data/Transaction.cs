using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntegrationExample4.Data
{
    internal class Transaction : IDisposable
    {
        public void Commit()
        {
            Console.WriteLine("Comitting transaction manually...");
        }

        public void Rollback()
        {
            Console.WriteLine("Rolling transaction back manually...");
        }

        public void Dispose()
        {
            Console.WriteLine("Disposing Transaction...");
        }
    }
}
