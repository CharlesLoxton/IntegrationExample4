using IntegrationExample4.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntegrationExample4.Responses
{
    internal class SagePurchaseOrderResponse : IResponse
    {
        //We have to add all the fields from the response object here
        public string? response_Id { get; set; }
        public int companyId { get; set; }
        public string? CompanyName { get; set; }
        public string? Name { get; set; }
        public string? Reference { get; set; }
    }
}
