using IntegrationExample4.Data;
using IntegrationExample4.Interfaces;
using IntegrationExample4.Models;
using IntegrationExample4.Responses;

namespace IntegrationExample4.Functions
{
    internal class SageAPI
    {
        //Will have a CRUD method for every Entity, only one for now because it's an example
        public IResponse PostSage(IEntity entity, string entityName) 
        {
            PostEntitiesSage sage = new PostEntitiesSage();

            switch (entityName)
            {
                case "Client":
                    return sage.PostClient(entity);
                case "Invoice":
                    return sage.PostInvoice(entity);
                case "Quote":
                    return sage.PostQuote(entity);
                case "PurchaseOrder":
                    return sage.PostPurchaseOrder(entity);
                default:
                    throw new ArgumentException("Invalid entity name");
            }
        }
    }
}
