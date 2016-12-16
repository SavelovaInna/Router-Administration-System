using System;
using System.Collections.Generic;

namespace lab3
{
    public abstract class NetInterface
    {
        protected int number;
        abstract public string name { get; }
        protected Dictionary<string,Setting> settings;
        public Dictionary<string, Setting> Settings
        {
            get
            {
                return settings;
            }
        }     
        public NetInterface(int number, string mac)
        {   
            settings=new Dictionary<string,Setting>();
            Setting setMac = new MacSetting();
            if (setMac.Change(mac))
                settings.Add("mac",setMac);
            settings.Add("ip", new IpSetting());
            this.number = number;
        }
        public bool ChangeSetting(string SettingName, string value)
        {
            return settings.ContainsKey(SettingName) && settings[SettingName].Change(value);
        }
        public void Reset()
        {
            foreach (string key in settings.Keys)
                settings[key].Reset();
        }
        public override string ToString()
        {
            return name;
        }
    }

    public class Wifi : NetInterface
    {
        public Wifi(int number,string mac) :base(number,mac)
        {
            settings.Add("frequence",new FrequencySetting());
        }
        override public string name{
            get
            {
                return "wifi"+Convert.ToString(number);
            }
        }
    }

    public class Ethernet : NetInterface
    {
        public Ethernet(int number, string mac) :base(number, mac){}
        override public string name
        {
            get
            {
                return "eth" + Convert.ToString(number);
            }
        }
    }

    public class Console : NetInterface
    {
        public Console(int number, string mac) :base(number, mac){}
        override public string name
        {
            get
            {
                return "console" + Convert.ToString(number);
            }
        }
    }
}
