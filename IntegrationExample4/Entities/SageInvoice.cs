using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IntegrationExample4.Interfaces;
using IntegrationExample4.Models;


namespace IntegrationExample4
{
    internal class SageInvoice : IInvoice_Actions
    {
        IGateway _gateway;

        public SageInvoice(IGateway gateway)
        {
            _gateway = gateway;
        }

        public IInvoice Upsert(IInvoice invoice)
        {
            try
            {
                string Token = _gateway.TokenRetrieval();

                IInvoice sageInvoice = new Invoice()
                {
                    Id = invoice.Id,
                    Name = invoice.Name
                };
                // Do something with the client object
                _gateway.TokenSave("token");
                return sageInvoice;

            }
            catch (Exception ex)
            {
                throw new Exception("Error:" + ex.Message);
            }
        }

        public void DeleteInvoice(int accountingProviderId)
        {
            throw new NotImplementedException();
        }

        public IInvoice ReadInvoice(int? accountingProviderId)
        {
            throw new NotImplementedException();
        }

    }
}
