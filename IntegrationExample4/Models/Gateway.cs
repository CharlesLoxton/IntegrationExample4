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
        public int UserId { get; set; }

        public Gateway(int userId)
        {
            UserId = userId;
        }

        public string RetrieveSelectedProvider()
        {
            Console.WriteLine("Retieving provider: Sage");
            return "Sage";
        }

        public void SaveSelectedProvider(string provider)
        {
            Console.WriteLine("Saving provider with name: " + provider);
        }

        public string TokenRetrieval()
        {
            Console.WriteLine("Retrieving token");
            return "123";
        }

        public void TokenSave(string token)
        {
            Console.WriteLine("Saving token in KOST");
        }

        public IEnumerable<Client> RetrieveAllClients()
        {
            List<Client> clients = new List<Client>();

            foreach (var item in clients)
            {
                yield return item;
            }
        }

        public void SaveAPLink(APLink link)
        {
            Console.WriteLine("Saving APLink in KOST");
        }

        public void SaveGUID(string entityName, int entityID, string guid)
        {
            Console.WriteLine("Saving guid in KOST");
        }

        public APLink FindEntityByGUID(string guid, string accountingProviderName)
        {
            Console.WriteLine("Finding APLink in KOST");

            //return an APLink object if the guid and APname matches in the table
            return null;
        }

        public void AddClient(Client client)
        {
            Console.WriteLine("Saving Client in KOST");
        }
    }
}
