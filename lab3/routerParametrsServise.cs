using System.Collections.Generic;
using System.IO;
using System;

namespace lab3
{
    class RouterParametersService : InterfaceRouterParametrsServise
    {
        Setting mac;
        List<NetInterface> interfaces;
        string path;
        public RouterParametersService(string path)
        {
            this.path = path;
            interfaces = new List<NetInterface>();
            mac = new MacSetting();
        }
        public void Load()
        {
            using (StreamReader reader = new StreamReader(path))
            {
                string s = reader.ReadLine();
                mac.Change(s);
                while ((s = reader.ReadLine()) != null)
                {
                    NetInterface netInterface = null;
                    switch (s)
                    {
                        case "eth":
                            netInterface = new Ethernet(interfaces.Count, mac.Value);
                            break;
                        case "wifi":
                            netInterface = new Wifi(interfaces.Count, mac.Value);
                            break;
                        case "con":
                            netInterface = new Console(interfaces.Count, mac.Value);
                            break;
                    }
                    int count = Convert.ToInt32(reader.ReadLine());
                    for (int i = 0; i < count; i++)
                    {
                        s = reader.ReadLine();
                        string[] split = s.Split(' ');
                        netInterface.ChangeSetting(split[0], split[1]);
                    }
                    interfaces.Add(netInterface);
                }
            }
        }
        public void Save()
        {
            using (StreamWriter writer = new StreamWriter(path))
            {
                writer.WriteLine(mac.Value);
                foreach (NetInterface netInterface in interfaces)
                {
                    writer.WriteLine(netInterface.name.Substring(0, netInterface.name.Length - 1));
                    writer.WriteLine(netInterface.Settings.Count);
                    foreach (string key in netInterface.Settings.Keys)
                        writer.WriteLine(key + ' ' + netInterface.Settings[key].Value);
                }
            }
        }
        public void Reset()
        {
            mac.Change("aa-aa-aa-aa-aa-aa");
            interfaces.ForEach(i => i.Reset());
        }
        public Setting GetMac()
        {
            return mac;
        }
        public bool SetMac(string value)
        {
            return mac.Change(value);
        }
        public List<NetInterface> GetListInterface()
        {         
            return interfaces;
        }
        public void SaveInterface(int i, NetInterface netInterface)
        {
            interfaces[i] = netInterface;
        }
    }
}
