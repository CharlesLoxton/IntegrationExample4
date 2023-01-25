using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntegrationExample4.Interfaces
{
    internal interface IInvoice
    {
        public int Id { get; set; }
        public string? Name { get; set; }
    }
}
