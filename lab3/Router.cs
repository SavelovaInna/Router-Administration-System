using System.Collections.Generic;

namespace lab3
{
    class Router
    {
        RouterParametersService parameterService;
        RoutingTable table;
        public Router()
        {
            parameterService = new RouterParametersService();
            table = new RoutingTable();
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
        public bool DeleteRoutingRecord(RoutingRecord record)
        {
            return table.DelRecord(record);
        }

    }
}
