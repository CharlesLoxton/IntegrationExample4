using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntegrationExample4.Interfaces
{
    internal interface IGateway
    {
        public int UserId { get; set; }

        public string TokenRetrieval();

        public void TokenSave(string token);

        public void SaveSelectedProvider(string provider);

        public string RetrieveSelectedProvider();

        public void StoreAccountingProviderID(object x, int entity_id, string api_id);
    }
}
