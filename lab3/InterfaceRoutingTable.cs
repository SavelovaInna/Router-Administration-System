using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3
{
    interface InterfaceRoutingTable
    {
        void Load();       
        void Save();        
        void Reset();       
        void AddRecord(RoutingRecord record);       
        void DelRecord(RoutingRecord record);
        List<RoutingRecord> GetRoutingTable(Query query);
       
    }
}
