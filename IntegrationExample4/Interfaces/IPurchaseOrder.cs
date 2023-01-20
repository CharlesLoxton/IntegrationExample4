using IntegrationExample4.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntegrationExample4.Interfaces
{
    internal interface IPurchaseOrder
    {
        void CreatePurchaseOrder(PurchaseOrder po, Action<PurchaseOrder>? successCallback, Action<Exception>? errorCallback);
        void ReadPurchaseOrder();
        void UpdatePurchaseOrder();
        void DeletePurchaseOrder();
    }
}
