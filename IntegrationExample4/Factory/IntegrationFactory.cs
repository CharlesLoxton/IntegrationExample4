using IntegrationExample4.Interfaces;
using IntegrationExample4.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntegrationExample4.Factory
{
    internal class IntegrationFactory
    {
        public AccountingProvider CreateAccountingProvider(IGateway gateway)
        {
            Console.WriteLine("Check if the user has a selected a provider");
            if (gateway.RetrieveSelectedProvider() == null) throw new Exception("Provider is null");
            Console.WriteLine("Creating Accounting provider class");
            return new AccountingProvider(gateway, gateway.RetrieveSelectedProvider());
        }
        
        public void CreateConnection(string provider, IGateway gateway)
        {
            if(provider == "Sage")
            {
                Console.WriteLine("Creating Initial connection with Sage");
                gateway.TokenSave("123");
                gateway.SaveSelectedProvider(provider);
            }
        }

        public void Disconnect(IGateway gateway, AccountingProvider AP)
        {
            AP._provider = "";
            Console.WriteLine("Disconencting Accounting Provider and setting values to null...");
            gateway.SaveSelectedProvider("");
            gateway.TokenSave("");
        }

        public async void Callback(string callbackUrl)
        {
            using (var client = new HttpClient())
            {
                var response = await client.GetAsync(callbackUrl);
                var responseString = await response.Content.ReadAsStringAsync();

                // Process the response and return the appropriate result
            }
        }
    }
}
