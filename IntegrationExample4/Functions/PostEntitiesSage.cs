using IntegrationExample4.Interfaces;
using IntegrationExample4.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntegrationExample4.Functions
{
    internal class PostEntitiesSage
    {
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
