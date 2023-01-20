using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IntegrationExample4.Interfaces;
using IntegrationExample4.Models;


namespace IntegrationExample4
{
    internal class SageInvoice : IInvoice
    {
        private Func<string> _tokenRetrievalFunc;
        private Func<string> _tokenSaveFunc;

        public SageInvoice(Func<string> tokenRetrievalFunc, Func<string> tokenSaveFunc)
        {
            _tokenRetrievalFunc = tokenRetrievalFunc;
            _tokenSaveFunc = tokenSaveFunc;
        }

        public void CreateInvoice(Invoice invoice, Action<Invoice>? successCallback, Action<Exception>? errorCallback)
        {
            try
            {
                string Token = _tokenRetrievalFunc();

                Invoice sageInvoice = new Invoice()
                {
                    Id = invoice.Id,
                    Name = invoice.Name
                };
                // Do something with the client object
                string save = _tokenSaveFunc();
                successCallback?.Invoke(sageInvoice);

            }
            catch (Exception ex)
            {
                errorCallback?.Invoke(ex);
            }
        }

        public void DeleteInvoice()
        {
            throw new NotImplementedException();
        }

        public void ReadInvoice()
        {
            throw new NotImplementedException();
        }

        public void UpdateInvoice()
        {
            throw new NotImplementedException();
        }
    }
}
