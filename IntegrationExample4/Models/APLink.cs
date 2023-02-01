using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntegrationExample4.Models
{
    internal class APLink
    {
        public int UserID { get; set; }

        public string? GUID { get; set; }

        public string? AccountingProviderID { get; set; }

        public string? AccountingProviderName { get; set; }

        public int? ComapnyID { get; set; }

        public string? ComapnyName { get; set; }

        public DateTime? ConnectedDate { get; set; }

        public DateTime? DisconnectedDate { get; set; }
    }
}
