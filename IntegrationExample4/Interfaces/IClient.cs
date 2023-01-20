using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IntegrationExample4.Models;

namespace IntegrationExample4.Interfaces
{
    internal interface IClient
    {
        void CreateClient(Client client, Action<Client>? successCallback, Action<Exception>? errorCallback);
        void ReadClient();
        void UpdateClient();
        void DeleteClient();
    }
}
