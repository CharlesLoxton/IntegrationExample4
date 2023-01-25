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
        IPurchaseOrder UpsertPurchaseOrder(IPurchaseOrder po);
        IPurchaseOrder ReadPurchaseOrder(int? accountingProviderId);
        void DeletePurchaseOrder(int accountingProviderId);
    }
}
