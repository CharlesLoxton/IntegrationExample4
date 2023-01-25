using IntegrationExample4.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntegrationExample4.Interfaces
{
    internal interface IQuote_Actions
    {
        IQuote UpsertQuote(IQuote quote);
        IQuote ReadQuote(int? accountingProviderId);
        void DeleteQuote(int accountingProviderId);
    }
}
