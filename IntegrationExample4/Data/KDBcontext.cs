using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntegrationExample4.Data
{
    internal class KDBcontext
    {
        //This is only for testing, the actual context class in EF core looks different.
        public Database Database;

        public KDBcontext() 
        {
            Database = new Database();
        }
    }
}
