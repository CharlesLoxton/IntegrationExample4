using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IntegrationExample4.Interfaces;
using IntegrationExample4.Models;

namespace IntegrationExample4
{
    internal class SageClient : IClient
    {
        private Func<string> _tokenRetrievalFunc;
        private Func<string> _tokenSaveFunc;

        public SageClient(Func<string> tokenRetrievalFunc, Func<string> tokenSaveFunc)
        {
            _tokenRetrievalFunc = tokenRetrievalFunc;
            _tokenSaveFunc = tokenSaveFunc;
        }

        public void CreateClient(Client client, Action<Client>? successCallback, Action<Exception>? errorCallback)
        {
            try
            {
                string Token = _tokenRetrievalFunc();
                Client sageClient = new Client()
                {
                    Id = client.Id,
                    Name = client.Name
                };

                Console.WriteLine("Creating Client in Sage");

                string save = _tokenSaveFunc();
                successCallback?.Invoke(sageClient);
            }
            catch(Exception ex)
            {
                errorCallback?.Invoke(ex);
            }
        }

        public void DeleteClient()
        {
            throw new NotImplementedException();
        }

        public void ReadClient()
        {
            throw new NotImplementedException();
        }

        public void UpdateClient()
        {
            throw new NotImplementedException();
        }
    }
}
