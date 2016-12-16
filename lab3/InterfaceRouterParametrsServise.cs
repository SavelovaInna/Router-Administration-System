using System.Collections.Generic;

namespace lab3
{
    interface InterfaceRouterParametrsServise
    {
        void Load();
        void Save();      
        void Reset();
        Setting GetMac();
        bool SetMac(string value);
        List<NetInterface> GetListInterface();
        void SaveInterface(int i, NetInterface netInterface);
    }
}
