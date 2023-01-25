using IntegrationExample4.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntegrationExample4.Models
{
    internal class Client : IClient
    {
        public int Id { get; set; }
        public string? Name { get; set; }

        public string GetAccountingProviderID(int id)
        {
            //Logic for retrieving Accounting Provider ID from Client table
            return "123";
        }

        public void SetAccountingProviderID(int id, string api_id)
        {
            //Logic for setting Accounting Provider ID from Client table
        }
    }
}
