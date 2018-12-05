using System.Collections.Generic;

namespace IteratorPattern
{
    public class ForwardIterator<T> : Iterator<T> where T : class
    {
        public ForwardIterator(Aggregate<T> list)
            :base(list)
        {
            First();
        }

        public override void First()
        {
            current = 0;
        }

        public override void Next()
        {
            current++;
        }

        public override bool IsDone() 
        {
            var ret = current >= list.Length;        
            return ret;
        }
    }
}