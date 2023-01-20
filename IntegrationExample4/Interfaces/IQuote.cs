using IntegrationExample4.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntegrationExample4.Interfaces
{
    internal interface IQuote
    {
        void CreateQuote(Quote quote, Action<Quote>? successCallback, Action<Exception>? errorCallback);
        void ReadQuote();
        void UpdateQuote();
        void DeleteQuote();
    }
}
