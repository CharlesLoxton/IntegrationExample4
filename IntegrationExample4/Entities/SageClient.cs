using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IntegrationExample4.Interfaces;
using IntegrationExample4.Models;

namespace IntegrationExample4
{
    internal class SageClient : IClient_Actions
    {
        IGateway _gateway;

        public SageClient(IGateway gateway)
        {
            _gateway= gateway;
        }

        public IClient Upsert(IClient client)
        {
            try
            {
                string Token = _gateway.TokenRetrieval();
                IClient sageClient = new Client()
                {
                    Id = client.Id,
                    Name = client.Name
                };

                Console.WriteLine("Creating Client in Sage");

                _gateway.TokenSave("Token");
                return sageClient;
            }
            catch(Exception ex)
            {
                throw new Exception("Error: " + ex.Message);
            }
        }

        public void DeleteClient(int accountingProviderId)
        {
            throw new NotImplementedException();
        }

        public IClient ReadClient(int? accountingProviderId)
        {
            throw new NotImplementedException();
        }

    }
}
