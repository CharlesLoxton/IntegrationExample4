using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IntegrationExample4.Interfaces;
using IntegrationExample4.Models;

namespace IntegrationExample4
{
    internal class SagePurchaseOrder : IPurchaseOrder
    {
        private Func<string> _tokenRetrievalFunc;
        private Func<string> _tokenSaveFunc;

        public SagePurchaseOrder(Func<string> tokenRetrievalFunc, Func<string> tokenSaveFunc)
        {
            _tokenRetrievalFunc = tokenRetrievalFunc;
            _tokenSaveFunc = tokenSaveFunc;
        }

        public void CreatePurchaseOrder(PurchaseOrder po, Action<PurchaseOrder>? successCallback, Action<Exception>? errorCallback)
        {
            try
            {
                string Token = _tokenRetrievalFunc();
                PurchaseOrder sagePO = new PurchaseOrder()
                {
                    Id = po.Id,
                    Name = po.Name
                };
                // Do something with the client object
                string save = _tokenSaveFunc();
                successCallback?.Invoke(sagePO);

            }
            catch (Exception ex)
            {
                errorCallback?.Invoke(ex);
            }
        }

        public void DeletePurchaseOrder()
        {
            throw new NotImplementedException();
        }

        public void ReadPurchaseOrder()
        {
            throw new NotImplementedException();
        }

        public void UpdatePurchaseOrder()
        {
            throw new NotImplementedException();
        }
    }
}
