using IntegrationExample4.Data;
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

        public string RetrieveSelectedProvider(KDBcontext context)
        {
            Console.WriteLine("Retieving provider: Sage\n");
            return "Sage";
        }

        public void SaveSelectedProvider(KDBcontext context, string provider)
        {
            Console.WriteLine("Saving provider with name: " + provider);
        }

        public string TokenRetrieval(KDBcontext context)
        {
            Console.WriteLine("Retrieving token");
            return "123";
        }

        public void TokenSave(KDBcontext context, string token)
        {
            Console.WriteLine("Saving token in KOST");
        }

        public IEnumerable<Client> RetrieveAllClients(KDBcontext context)
        {
            List<Client> clients = new List<Client>();

            foreach (var item in clients)
            {
                yield return item;
            }
        }

        public void SaveAPLink(KDBcontext context, APLink link)
        {
            Console.WriteLine("Saving APLink in KOST");
        }

        public void SaveGUID(KDBcontext context, string entityName, int entityID, string guid)
        {
            Console.WriteLine("Saving guid in KOST");
        }

        public APLink FindAPLinkByGUID(KDBcontext context, string guid, string accountingProviderName)
        {
            Console.WriteLine("Finding APLink in KOST");

            //return an APLink object if the guid and APname matches in the table
            return null;
        }

        public void AddClient(KDBcontext context, Client client)
        {
            Console.WriteLine("Saving Client in KOST");
        }
    }
}
