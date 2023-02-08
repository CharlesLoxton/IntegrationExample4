using IntegrationExample4.Data;
using IntegrationExample4.Interfaces;
using IntegrationExample4.Models;

namespace IntegrationExample4.Functions
{
    internal class AccountingProviderAPI
    {
        KDBcontext _context;
        IGateway _gateway;
 
        public AccountingProviderAPI(KDBcontext context, IGateway gateway) 
        {
            _context = context;
            _gateway = gateway;
        }

        //This is a universal way of Posting for all entities
        public void Post(IEntity entity, string provider)
        {
            try
            {
                IResponse? response = null;

                string Token = _gateway.TokenRetrieval(_context);

                //Check if client.GUID exists in our APLink table
                if (entity.GUID != null)
                {
                    APLink link = _gateway.FindAPLinkByGUID(_context, entity.GUID, provider);
                    //If it returns an APLink object we know it exists in Sage, but we should do a GET check to make sure

                    //Updating the Entity in Sage happens here
                }

                else//This would be a first time Create
                {
                    switch (provider)
                    {
                        case "Sage":
                            response = new SageAPI().PostSage(entity, entity.GetType().Name);
                            break;
                        case "Xero":
                            //response = new XeroAPI().PostXero(entity, ReturnType(entity));
                            break;
                        case "Quickbooks":
                            //response = new QuickBooksAPI().PostQuickBooks(entity, ReturnType(entity));
                            break;
                        default:
                            throw new ArgumentException("Invalid provider name");
                    }

                    if (response == null) return;

                    APLink link = new APLink()
                    {
                        UserID = entity.UserID,
                        GUID = response.Reference,
                        AccountingProviderID = response.response_Id,
                        provider = new ProviderInfo()
                        {
                            AccountingProviderName = provider,
                            ComapnyID = response.companyId,
                            ComapnyName = response.CompanyName,
                        },
                        date = new DateInfo()
                        {
                            ConnectedDate = DateTime.Now,
                            DisconnectedDate = null
                        }
                    };

                    _gateway.SaveGUID(_context, entity.GetType().Name, entity.Id, response.Reference);
                    _gateway.SaveAPLink(_context, link);
                    _gateway.TokenSave(_context, Guid.NewGuid().ToString());
                }

                Console.WriteLine("Creating Entity Completed");
                Console.WriteLine("\n");
            }
            catch (Exception ex)
            {
                throw new Exception("Error in Posting to Sage " + ex.Message);
            }
        }
    }
}

