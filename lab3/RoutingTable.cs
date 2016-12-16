using System.Collections.Generic;
using System.IO;
using System;

namespace lab3
{
    class RoutingTable : InterfaceRoutingTable
    {
        List<RoutingRecord> table;
        string path;
        public RoutingTable(string path)
        {
            this.path = path;
            table = new List<RoutingRecord>();
        }
        public void Load()
        {
            using (StreamReader reader = new StreamReader(path))
            {
                string s;
                while ((s = reader.ReadLine()) != null)
                {
                    string[] split = s.Split(' ');
                    RoutingRecord record = new RoutingRecord();
                    record.SetParameters(split[0], split[1], split[2],
                        Convert.ToInt32(split[3]));
                    table.Add(record);
                }
            }
        }
        public void Save()
        {
            using (StreamWriter writer = new StreamWriter(path))
            {
                table.ForEach(r => writer.WriteLine("{0} {1} {2} {3}",
                    r.dest, r.mask, r.gateway, r.metric));
            }
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
