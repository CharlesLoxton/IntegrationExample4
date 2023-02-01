using IntegrationExample4.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntegrationExample4.Interfaces
{
    internal interface IGateway
    {
        public int UserId { get; set; }

        public string TokenRetrieval(); //Retrieve the API Token where Kost.UserID = this.UserID

        public void TokenSave(string token); //Save the API token where Kost.UserID = this.UserID

        public void SaveSelectedProvider(string provider); //Save the Provider Name where Kost.UserID = this.UserID

        public string RetrieveSelectedProvider(); //Retrieve the provider Name where Kost.UserID = this.UserID

        public void SaveAPLink(APLink link); //Add APLink object to APLink Table in KOST Database

        public void SaveGUID(string entityName, int entityID, string guid); //Save the GUID for the corresponding entity object

        public APLink FindEntityByGUID(string guid, string accountingProviderName); //return APLink where APLink.GUID = guid and APLink.accountingProviderName = accountingProviderName

        public IEnumerable<Client> RetrieveAllClients(); //Yield return a list of clients where Kost.UserID = this.UserID

        public void AddClient(Client client); //Add a client for a user where Kost.UserID = this.UserID
    }
}
