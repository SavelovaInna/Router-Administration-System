using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using lab3;

namespace RouterTests
{
    public class TestRoutingTable : InterfaceRoutingTable
    {
        public List<RoutingRecord> table;
        public void Load()
        {
            table = new List<RoutingRecord>();
            RoutingRecord record = new RoutingRecord();
            record.SetParameters("192.168.1.1","255.255.255.0", "1.1.2.1", 6);
            table.Add(record);
            record = new RoutingRecord();
            record.SetParameters("5.5.5.5", "255.0.0.0", "2.2.2.2", 7);
            table.Add(record);
        }
        public void Save()
        {
            
        }
        public void Reset()
        {
            table.Clear();
        }
        public void AddRecord(RoutingRecord record)
        {
            table.Add(record);
        }
        public void DelRecord(RoutingRecord record)
        {
            table.Remove(record);
        }
        public List<RoutingRecord> GetRoutingTable(Query query)
        {
            List<RoutingRecord> queryTable = new List<RoutingRecord>();
            foreach (RoutingRecord record in table)
            {
                if (query.IsSatisfiedBy(record))
                    queryTable.Add(record);
            }
            return queryTable;
        }
    }
}
