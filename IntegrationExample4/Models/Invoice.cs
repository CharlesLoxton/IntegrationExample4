using IntegrationExample4.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntegrationExample4.Models
{
    internal class Invoice : IInvoice
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? GUID { get; set; }
        public int UserID { get; set; }
    }
}
