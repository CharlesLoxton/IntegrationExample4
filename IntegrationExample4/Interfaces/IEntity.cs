using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntegrationExample4.Interfaces
{
    internal interface IEntity
    {
        //These are properties that are universal for all entities
        public string? Name { get; set; }
        public int Id { get; set; }
        public int UserID { get; set; }
        public string? GUID { get; set; }
    }
}
