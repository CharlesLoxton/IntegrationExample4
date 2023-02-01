using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IntegrationExample4.Models;

namespace IntegrationExample4.Interfaces
{
    internal interface IClient_Actions
    {
        IClient Upsert(IClient client);
        IClient Read(int? accountingProviderId);
        void Delete(int accountingProviderId);
        void Sync();
    }
}
