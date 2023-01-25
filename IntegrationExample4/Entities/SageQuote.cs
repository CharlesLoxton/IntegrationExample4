using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IntegrationExample4.Interfaces;
using IntegrationExample4.Models;

namespace IntegrationExample4
{
    internal class SageQuote : IQuote_Actions
    {
        IGateway _gateway;
        public SageQuote(IGateway gateway)
        {
            _gateway = gateway;
        }

        public IQuote UpsertQuote(IQuote quote)
        {
            try
            {
                string Token = _gateway.TokenRetrieval();

                IQuote sageQuote = new Quote()
                {
                    Id = quote.Id,
                    Name = quote.Name
                };
                // Do something with the client object
                _gateway.TokenSave("Token");
                return sageQuote;

            }
            catch (Exception ex)
            {
                throw new Exception("Error: " + ex.Message);
            }
        }

        public void DeleteQuote(int accountingProviderId)
        {
            throw new NotImplementedException();
        }

        public IQuote ReadQuote(int? accountingProviderId)
        {
            throw new NotImplementedException();
        }
    }
}
