namespace lab3
{
    public class RoutingRecord
    {
        public string dest;
        public string mask;
        public string gateway;
        public int metric;

        public void SetParameters(string dest, string mask, string gateway, int metric)
        {
            this.dest = dest;
            this.mask = mask;
            this.gateway = gateway;
            this.metric = metric;
        }
        public override bool Equals(object obj)
        {
            return obj is RoutingRecord && dest.Equals(((RoutingRecord)obj).dest) &&
                mask.Equals(((RoutingRecord)obj).mask) && 
                gateway.Equals(((RoutingRecord)obj).gateway) &&
                metric==((RoutingRecord)obj).metric;
        }
    }
}
