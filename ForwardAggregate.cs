using System.Collections.Generic;

namespace IteratorPattern
{
    public class ForwardAggregate<T> : Aggregate<T> where T : class
    {
        public ForwardAggregate(List<T> list) : base(list){}

        public override Iterator<T> CreateIterator() => new ForwardIterator<T>(this);
    }
}