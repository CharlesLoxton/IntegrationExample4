using IntegrationExample4.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntegrationExample4.Factory
{
    internal class AccountingProviderFactory
    {
        public Func<string> _tokenRetrievalFunc;
        public Func<string> _tokenSaveFunc;

        public AccountingProviderFactory(Func<string> tokenRetrievalFunc, Func<string> tokenSaveFunc)
        {
            _tokenRetrievalFunc = tokenRetrievalFunc;
            _tokenSaveFunc = tokenSaveFunc;
        }

        public IClient Client(string provider)
        {
            switch (provider)
            {
                case "Sage":
                    return new SageClient(_tokenRetrievalFunc, _tokenSaveFunc);
                case "Xero":
                    //return new XeroClient();
                case "Quickbooks":
                    //return new QuickbooksClient();
                default:
                    throw new ArgumentException("Invalid provider name");
            }
        }

        public IQuote Quote(string provider)
        {
            switch (provider)
            {
                case "Sage":
                    return new SageQuote(_tokenRetrievalFunc, _tokenSaveFunc);
                case "Xero":
                    //return new XeroQuote();
                case "Quickbooks":
                    //return new QuickbooksQuote();
                default:
                    throw new ArgumentException("Invalid provider name");
            }
        }

        public IInvoice Invoice(string provider)
        {
            switch (provider)
            {
                case "Sage":
                    return new SageInvoice(_tokenRetrievalFunc, _tokenSaveFunc);
                case "Xero":
                    //return new XeroInvoice();
                case "Quickbooks":
                    //return new QuickbooksInvoice();
                default:
                    throw new ArgumentException("Invalid provider name");
            }
        }

        public IPurchaseOrder PurchaseOrder(string provider)
        {
            switch (provider)
            {
                case "Sage":
                    return new SagePurchaseOrder(_tokenRetrievalFunc, _tokenSaveFunc);
                case "Xero":
                    //return new XeroPurchaseOrder();
                case "Quickbooks":
                    //return new QuickbooksPurchaseOrder();
                default:
                    throw new ArgumentException("Invalid provider name");
            }
        }
    }
}
