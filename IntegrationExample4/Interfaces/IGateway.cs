using IntegrationExample4.Data;
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

        public string TokenRetrieval(KDBcontext context); //Retrieve the API Token where Kost.UserID = this.UserID

        public void TokenSave(KDBcontext context, string token); //Save the API token where Kost.UserID = this.UserID

        public void SaveSelectedProvider(KDBcontext context, string provider); //Save the Provider Name where Kost.UserID = this.UserID

        public string RetrieveSelectedProvider(KDBcontext context); //Retrieve the provider Name where Kost.UserID = this.UserID

        public void SaveAPLink(KDBcontext context, APLink link); //Add APLink object to APLink Table in KOST Database

        public void SaveGUID(KDBcontext context, string entityName, int entityID, string guid); //Save the GUID for the corresponding entity object

        public APLink FindAPLinkByGUID(KDBcontext context, string guid, string accountingProviderName); //return APLink where APLink.GUID = guid and APLink.accountingProviderName = accountingProviderName

        public IEnumerable<Client> RetrieveAllClients(KDBcontext context); //Yield return a list of clients where Kost.UserID = this.UserID

        public void AddClient(KDBcontext context, Client client); //Add a client for a user where Kost.UserID = this.UserID
    }
}
