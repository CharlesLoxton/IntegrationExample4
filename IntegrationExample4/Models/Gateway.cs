using IntegrationExample4.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntegrationExample4.Models
{
    internal class Gateway : IGateway
    {
        public int UserId { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public Gateway(int userId)
        {
            UserId = userId;
        }

        public string RetrieveSelectedProvider()
        {
            Console.WriteLine("Retieving proivder: Sage");
            return "Sage";
        }

        public void SaveSelectedProvider(string provider)
        {
            Console.WriteLine("Saving provider name: " + provider);
        }

        public void StoreAccountingProviderID(object x, int entity_id, string api_id)
        {
            Console.WriteLine("Storing Entity ID: " + api_id);
        }

        public string TokenRetrieval()
        {
            Console.WriteLine("Retrieving token: 123");
            return "123";
        }

        public void TokenSave(string token)
        {
            Console.WriteLine("Saving token: " + token);
        }
    }
}
