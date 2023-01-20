using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IntegrationExample4.Interfaces;
using IntegrationExample4.Models;

namespace IntegrationExample4
{
    internal class SageQuote : IQuote
    {
        private Func<string> _tokenRetrievalFunc;
        private Func<string> _tokenSaveFunc;

        public SageQuote(Func<string> tokenRetrievalFunc, Func<string> tokenSaveFunc)
        {
            _tokenRetrievalFunc = tokenRetrievalFunc;
            _tokenSaveFunc = tokenSaveFunc;
        }

        public void CreateQuote(Quote quote, Action<Quote>? successCallback, Action<Exception>? errorCallback)
        {
            try
            {
                string Token = _tokenRetrievalFunc();

                Quote sageQuote = new Quote()
                {
                    Id = quote.Id,
                    Name = quote.Name
                };
                // Do something with the client object
                string save = _tokenSaveFunc();
                successCallback?.Invoke(sageQuote);

            }
            catch (Exception ex)
            {
                errorCallback?.Invoke(ex);
            }
        }

        public void DeleteQuote()
        {
            throw new NotImplementedException();
        }

        public void ReadQuote()
        {
            throw new NotImplementedException();
        }

        public void UpdateQuote()
        {
            throw new NotImplementedException();
        }
    }
}
