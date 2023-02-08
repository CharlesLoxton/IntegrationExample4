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
            switch (entityName)
            {
                case "Client":
                    return PostClient(entity);
                case "Invoice":
                    return PostInvoice(entity);
                case "Quote":
                    return PostQuote(entity);
                case "PurchaseOrder":
                    return PostPurchaseOrder(entity);
                default:
                    throw new ArgumentException("Invalid entity name");
            }
        }

        //We cann abstract the below methods even more, but for now I leave them here
        public IResponse PostClient(IEntity entity) 
        {
            Console.WriteLine("Posting Client to Sage");

            return new SageClientResponse()
            {
                response_Id = Guid.NewGuid().ToString(),
                companyId = 34235,
                CompanyName = "BoBTheBuilder",
                Name = entity.Name,
                Reference = entity.GUID
            };
        }

        public IResponse PostInvoice(IEntity entity)
        {
            Console.WriteLine("Posting Invoice to Sage");

            return new SageInvoiceResponse()
            {
                response_Id = Guid.NewGuid().ToString(),
                companyId = 34235,
                CompanyName = "BoBTheBuilder",
                Name = entity.Name,
                Reference = entity.GUID
            };
        }

        public IResponse PostQuote(IEntity entity)
        {
            return new SageQuoteResponse()
            {
                response_Id = Guid.NewGuid().ToString(),
                companyId = 34235,
                CompanyName = "BoBTheBuilder",
                Name = entity.Name,
                Reference = entity.GUID
            };
        }

        public IResponse PostPurchaseOrder(IEntity entity)
        {
            return new SagePurchaseOrderResponse()
            {
                response_Id = Guid.NewGuid().ToString(),
                companyId = 34235,
                CompanyName = "BoBTheBuilder",
                Name = entity.Name,
                Reference = entity.GUID
            };
        }
    }
}
