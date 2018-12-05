using System.Collections.Generic;

namespace IteratorPattern
{
    public class BackwardAggregate<T> : Aggregate<T> where T : class
    {
        public BackwardAggregate(List<T> list): base(list) {}        
        public override Iterator<T> CreateIterator() => new BackwardIterator<T>(this);        
    }
}