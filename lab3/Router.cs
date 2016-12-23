using System;
using System.Collections.Generic;

namespace lab3
{
    public class Router
    {
        InterfaceRouterParametrsServise parameterService;
        InterfaceRoutingTable table;
        public Router(InterfaceRouterParametrsServise parameterService,InterfaceRoutingTable table)
        {
            this.parameterService = parameterService;
            this.table = table;
        }
        public void Load()
        {
            parameterService.Load();
            table.Load();
        }
        public void Save()
        {
            parameterService.Save();
            table.Save();
        }
        public void Reset()
        {
            parameterService.Reset();
            table.Reset();
        }
        public Setting GetMac()
        {
            return parameterService.GetMac();
        }
        public bool SetMac(string address)
        {
            return parameterService.SetMac(address);
        }
        public List<NetInterface> GetInterfaces()
        {
            return parameterService.GetListInterface();
        }
        public bool SaveInterface(NetInterface netInterface)
        {
            List<NetInterface> interfaces = parameterService.GetListInterface();
            int i = 0;
            while (i < interfaces.Count &&
                !interfaces[i].name.Equals(netInterface.name))
            {
                i++;
            }
            if (i == interfaces.Count)
                return false;
            parameterService.SaveInterface(i, netInterface);
            return true;          
        }
        public List<RoutingRecord> GetRoutingTable(Query query)
        {
            return table.GetRoutingTable(query);
        }
        public void AddRoutingRecord(RoutingRecord record)
        {
            table.AddRecord(record);
        }
        public void DeleteRoutingRecord(RoutingRecord record)
        {
            table.DelRecord(record);
        }
    }
}
