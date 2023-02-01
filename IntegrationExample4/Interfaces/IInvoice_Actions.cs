using IntegrationExample4.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntegrationExample4.Interfaces
{
    internal interface IInvoice_Actions
    {
        IInvoice Upsert(IInvoice invoice);
        IInvoice Read(int? accountingProviderId);
        void Delete(int accountingProviderId);
        void Sync();
    }
}
