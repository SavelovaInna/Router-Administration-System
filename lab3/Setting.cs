using System;
using System.Text.RegularExpressions;

namespace lab3
{
    public abstract class Setting
    {
        protected string stringValue;
        public string Value { get { return stringValue; } }
        public abstract bool IsFormat(string value);

        public bool Change(string value)
        {
            if (!IsFormat(value))
                return false;
            stringValue = value;
            return true;
        }
        public void Reset() 
        {
            stringValue = "";
        }
    }

    public class IpSetting : Setting
    {
        private Regex rgxIp = new Regex(@"(25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?(\.|$)){4}");
        public override bool IsFormat(string value)
        {
            return rgxIp.IsMatch(value) || value.Equals("");
        }
    }

    public class MacSetting : Setting
    {
        private Regex rgxMac = new Regex(@"([0-9a-fA-F]{2}([:-]|$)){6}$|([0-9a-fA-F]{4}([.]|$)){3}");
        public override bool IsFormat(string value)
        {
            return rgxMac.IsMatch(value) || value.Equals("");
        }
    }

    public class FrequencySetting : Setting
    {
        double DoubleValue;
        public override bool IsFormat(string value)
        {
            return Double.TryParse(value, out DoubleValue) || value.Equals("");
        }
    }
}
