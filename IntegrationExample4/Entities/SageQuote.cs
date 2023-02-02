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

        public IQuote Upsert(IQuote quote)
        {
            try
            {
                Console.WriteLine("Upsert for Quote has been called on IQuote_Actions");
                IQuote sageQuote = new Quote();
                string Token = _gateway.TokenRetrieval();

                //Check if client.GUID exists in our APLink table
                if (quote.GUID != null)
                {
                    APLink link = _gateway.FindAPLinkByGUID(quote.GUID, "Sage");
                    //If it returns an APLink object we know it exists in Sage

                    //Now we make a call to sage using the Get method and the link.AccountingProviderID
                    //If this returns a quote from Sage, we have to compare the objects and update Sage
                    //If it does not return an object then this means the user switched instances or deleted it, so we do a 
                    //POST request to Sage to recreate the quote
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
                        UserID = quote.UserID,
                        GUID = guid,
                        AccountingProviderID = response_Id,
                        ComapnyID = companyId,
                        ComapnyName = companyName,
                        ConnectedDate = DateTime.Now,
                        DisconnectedDate = null
                    };

                    _gateway.SaveGUID("PurchaseOrder", quote.Id, guid);
                    _gateway.SaveAPLink(link);
                    _gateway.TokenSave("432423423fdsfsdf2f34re2fsdfa");

                    sageQuote.Id = quote.Id;
                    sageQuote.Name = quote.Name;
                    sageQuote.GUID = guid;
                    sageQuote.UserID = quote.UserID;
                }

                return sageQuote;
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

        public IQuote Read(int? accountingProviderId)
        {
            throw new NotImplementedException();
        }

        public void Sync()
        {

        }
    }
}
