using IntegrationExample4.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntegrationExample4.Interfaces
{
    internal interface IInvoice
    {
        void CreateInvoice(Invoice invoice, Action<Invoice>? successCallback, Action<Exception>? errorCallback);
        void ReadInvoice();
        void UpdateInvoice();
        void DeleteInvoice();
    }
}
