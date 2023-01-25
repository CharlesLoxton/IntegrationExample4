using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntegrationExample4.Interfaces
{
    internal interface IClient
    {
        public int Id { get; set; }
        public string? Name { get; set; }

        public void SetAccountingProviderID(int id, string api_id);

        public string GetAccountingProviderID(int id);
    }
}
