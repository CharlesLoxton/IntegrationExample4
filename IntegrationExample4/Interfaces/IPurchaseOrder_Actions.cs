using IntegrationExample4.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntegrationExample4.Interfaces
{
    internal interface IPurchaseOrder_Actions
    {
        void Upsert(IPurchaseOrder po);
        IPurchaseOrder Read(int? accountingProviderId);
        void Delete(int accountingProviderId);
        void Sync();
    }
}
