using IntegrationExample4.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntegrationExample4.Models
{
    internal class PurchaseOrder : IPurchaseOrder
    {
        public int Id { get; set; }
        public string? Name { get; set; }
    }
}
