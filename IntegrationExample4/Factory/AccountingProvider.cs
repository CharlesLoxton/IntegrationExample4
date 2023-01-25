using IntegrationExample4.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntegrationExample4.Factory
{
    internal class AccountingProvider
    {
        IGateway _gateway;
        public string _provider;

        public AccountingProvider(IGateway gateway, string provider)
        {
            _gateway = gateway;
            _provider = provider;
        }

        public IClient_Actions Client()
        {
            switch (_provider)
            {
                case "Sage":
                    return new SageClient(_gateway);
                case "Xero":
                //return new XeroClient();
                case "Quickbooks":
                //return new QuickbooksClient();
                default:
                    throw new ArgumentException("Invalid provider name");
            }
        }

        public IQuote_Actions Quote()
        {
            switch (_provider)
            {
                case "Sage":
                    return new SageQuote(_gateway);
                case "Xero":
                //return new XeroQuote();
                case "Quickbooks":
                //return new QuickbooksQuote();
                default:
                    throw new ArgumentException("Invalid provider name");
            }
        }

        public IInvoice_Actions Invoice()
        {
            switch (_provider)
            {
                case "Sage":
                    return new SageInvoice(_gateway);
                case "Xero":
                //return new XeroInvoice();
                case "Quickbooks":
                //return new QuickbooksInvoice();
                default:
                    throw new ArgumentException("Invalid provider name");
            }
        }

        public IPurchaseOrder_Actions PurchaseOrder()
        {
            switch (_provider)
            {
                case "Sage":
                    return new SagePurchaseOrder(_gateway);
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
