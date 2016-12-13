namespace lab3
{
    public abstract class Query
    {
        public abstract bool IsSatisfiedBy(object candidate);

        public Query And(Query other)
        {
            return new AndQuery(this, other);
        }

        public Query Or(Query other)
        {
            return new OrQuery(this, other);
        }

        public Query Not()
        {
            return new NotQuery(this);
        }
    }
    public class AndQuery : Query
    {
        private Query one;
        private Query other;

        public AndQuery(Query x, Query y)
        {
            one = x;
            other = y;
        }

        public override bool IsSatisfiedBy(object candidate)
        {
            return one.IsSatisfiedBy(candidate) && other.IsSatisfiedBy(candidate);
        }
    }

    public class OrQuery : Query
    {
        private Query one;
        private Query other;

        public OrQuery(Query x, Query y)
        {
            one = x;
            other = y;
        }

        public override bool IsSatisfiedBy(object candidate)
        {
            return one.IsSatisfiedBy(candidate) || other.IsSatisfiedBy(candidate);
        }
    }

    public class NotQuery : Query
    {
        private Query one;

        public NotQuery(Query x)
        {
            one = x;
        }

        public override bool IsSatisfiedBy(object candidate)
        {
            return !one.IsSatisfiedBy(candidate);
        }
    }

    public class DestQuery: Query
    {
        string sample;

        public DestQuery(string sample)
        {
            this.sample = sample;
        }
        public override bool IsSatisfiedBy(object candidate)
        {
            return candidate is RoutingRecord &&
                (sample.Equals("") ||
                ((RoutingRecord)candidate).dest.Equals(sample));
        }
    }

    public class GatewayQuery : Query
    {
        string sample;

        public GatewayQuery(string sample)
        {
            this.sample = sample;
        }
        public override bool IsSatisfiedBy(object candidate)
        {
            return candidate is RoutingRecord && 
                (sample.Equals("") ||
                ((RoutingRecord)candidate).gateway.Equals(sample));
        }
    }
}
