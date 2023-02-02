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
                Console.WriteLine("Upsert for Invoice has been called on IInvoice_Actions");

                IInvoice sageInvoice = new Invoice();
                string Token = _gateway.TokenRetrieval();

                //Check if client.GUID exists in our APLink table
                if (invoice.GUID != null)
                {
                    APLink link = _gateway.FindAPLinkByGUID(invoice.GUID, "Sage");
                    //If it returns an APLink object we know it exists in Sage

                    //Now we make a call to sage using the Get method and the link.AccountingProviderID
                    //If this returns an invoice from Sage, we have to compare the objects and update Sage
                    //If it does not return an object then this means the user switched instances or deleted it, so we do a 
                    //POST request to Sage to recreate the invoice
                }
                else//This would be a first time push
                {
                    //We generate a guid using a library or our own method
                    string guid = "dsadas56da4sd4ad4asddasd";

                    //Logic for making upsert to Sage
                    Console.WriteLine("Creating Invoice in Sage");

                    //Sage gives us a response with the ID
                    string response_Id = "13213123123";

                    //Save the company Id, it's either in the response from Sage or we have to make another request...
                    int companyId = 32534;
                    string companyName = "BobTheBuilder";

                    APLink link = new APLink()
                    {
                        UserID = invoice.UserID,
                        GUID = guid,
                        AccountingProviderID = response_Id,
                        ComapnyID = companyId,
                        ComapnyName = companyName,
                        ConnectedDate = DateTime.Now,
                        DisconnectedDate = null
                    };

                    _gateway.SaveGUID("Invoice", invoice.Id, guid);
                    _gateway.SaveAPLink(link);
                    _gateway.TokenSave("432423423fdsfsdf2f34re2fsdfa");

                    sageInvoice.Id = invoice.Id;
                    sageInvoice.Name = invoice.Name;
                    sageInvoice.GUID = guid;
                    sageInvoice.UserID = invoice.UserID;
                }
                Console.WriteLine("Creating invoice Completed");
                Console.WriteLine("\n");
                return sageInvoice;
            }
            catch (Exception ex)
            {
                throw new Exception("Error: " + ex.Message);
            }
        }

        public void Delete(int accountingProviderId)
        {
            throw new NotImplementedException();
        }

        public IInvoice Read(int? accountingProviderId)
        {
            throw new NotImplementedException();
        }

        public void Sync()
        {
            throw new NotImplementedException();
        }
    }
}
