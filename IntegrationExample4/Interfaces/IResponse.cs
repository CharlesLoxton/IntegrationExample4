using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntegrationExample4.Interfaces
{
    internal interface IResponse
    {
        public string? response_Id { get; set; }
        public int companyId { get; set; }
        public string? CompanyName { get; set; }
        public string? Name { get; set; }
        public string? Reference { get; set; }
    }
}
