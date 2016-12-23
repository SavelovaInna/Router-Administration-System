using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using lab3;

namespace RouterTests
{
    public class TestRouterParametrServise : InterfaceRouterParametrsServise
    {
        public Setting mac;
        public List<NetInterface> interfaces;
        public void Load()
        {
            mac = new MacSetting();
            mac.Change("12-12-12-12-12-12");
            interfaces = new List<NetInterface>();
            NetInterface eth1 = new Ethernet(0, "12-12-12-12-12-12");
            NetInterface wifi = new Wifi(1, "12-12-12-12-12-12");
            NetInterface console = new lab3.Console(2, "12-12-12-12-12-12");
            interfaces.Add(eth1);
            interfaces.Add(wifi);
            interfaces.Add(console);
        }
        public void Save()
        {
            
        }
        public void Reset()
        {
            mac.Change("00-00-00-00-00-00");
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
