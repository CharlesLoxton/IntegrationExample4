using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IntegrationExample4.Interfaces;
using IntegrationExample4.Models;

namespace IntegrationExample4
{
    internal class SagePurchaseOrder : IPurchaseOrder_Actions
    {
        IGateway _gateway;
        public SagePurchaseOrder(IGateway gateway)
        {
            _gateway = gateway;
        }

        public IPurchaseOrder UpsertPurchaseOrder(IPurchaseOrder po)
        {
            try
            {
                string Token = _gateway.TokenRetrieval();
                IPurchaseOrder sagePO = new PurchaseOrder()
                {
                    Id = po.Id,
                    Name = po.Name
                };
                // Do something with the client object
                _gateway.TokenSave("Token");
                return sagePO;

            }
            catch (Exception ex)
            {
                throw new Exception("Error:" + ex.Message);
            }
        }   

        public IPurchaseOrder ReadPurchaseOrder(int? accountingProviderId)
        {
            throw new NotImplementedException();
        }

        public void DeletePurchaseOrder(int accountingProviderId)
        {
            throw new NotImplementedException();
        }
    }
}
