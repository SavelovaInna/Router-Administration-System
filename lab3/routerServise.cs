using System.Collections.Generic;
using System.IO;
using System;

namespace lab3
{
    class RouterParametersService
    {
        Setting mac;
        List<NetInterface> interfaces;
        string path = "parConfig.txt";
        public RouterParametersService()
        {
            interfaces = new List<NetInterface>();
            mac = new MacSetting();
        }
        public void Load()
        {        
            StreamReader reader = new StreamReader(path);
            string s = reader.ReadLine();
            mac.Change(s);
            while ((s = reader.ReadLine()) != null)
            {
                NetInterface interfac = null;
                switch (s)
                {
                    case "eth":
                        interfac = new Ethernet(interfaces.Count, mac.Value);
                        break;
                    case "wifi":
                        interfac = new Wifi(interfaces.Count, mac.Value);
                        break;
                    case "con":
                        interfac = new Console(interfaces.Count, mac.Value);
                        break;
                }
                int k = Convert.ToInt32(reader.ReadLine());
                for (int i = 0; i < k; i++)
                {
                    s = reader.ReadLine();
                    string[] split = s.Split(' ');
                    interfac.ChangeSetting(split[0], split[1]);
                }
                interfaces.Add(interfac);
            }
            reader.Close();
        }
        public void Save()
        {
            StreamWriter writer = new StreamWriter(path);
            writer.WriteLine(mac.Value);
            foreach (NetInterface interf in interfaces)
            {
                writer.WriteLine(interf.name.Substring(0,interf.name.Length-1));
                writer.WriteLine(interf.Settings.Count);
                foreach(string key in interf.Settings.Keys)
                    writer.WriteLine(key +' '+interf.Settings[key].Value);
            }
            writer.Close();
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
