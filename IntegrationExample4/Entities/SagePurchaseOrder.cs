using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IntegrationExample4.Data;
using IntegrationExample4.Functions;
using IntegrationExample4.Interfaces;
using IntegrationExample4.Models;

namespace IntegrationExample4
{
    internal class SagePurchaseOrder : IPurchaseOrder_Actions
    {
        IGateway _gateway;
        KDBcontext _context;

        public SagePurchaseOrder(IGateway gateway, KDBcontext context)
        {
            _gateway = gateway;
            _context = context;
        }

        public void Upsert(IPurchaseOrder po)
        {
            try
            {
                AccountingProviderAPI api = new AccountingProviderAPI(_context, _gateway);
                IEntity sagePO = new PurchaseOrder();

                //We need to check if Neil is using transactions, if he isn't then we have to manually create a transaction in EF core
                if (_context.Database.CurrentTransaction != null)
                {
                    api.Post(po, "Sage");
                }
                else
                {
                    using (var transaction = _context.Database.BeginTransaction())
                    {
                        try
                        {
                            api.Post(po, "Sage");
                            transaction.Commit();
                        }
                        catch (Exception)
                        {
                            transaction.Rollback();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error: " + ex.Message);
            }
        }   

        public IPurchaseOrder Read(int? accountingProviderId)
        {
            throw new NotImplementedException();
        }

        public void Delete(int accountingProviderId)
        {
            throw new NotImplementedException();
        }

        public void Sync()
        {
            throw new NotImplementedException();
        }
    }
}
