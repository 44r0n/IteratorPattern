using System.Collections.Generic;

namespace IteratorPattern
{
    public class BackwardIterator<T> : Iterator<T> where T : class
    {
        public BackwardIterator(Aggregate<T> list)
            :base(list)
        {
            First();
        }

        public override void First()
        {
            current = list.Length - 1;
        }

        public override void Next()
        {
            current--;
        }

        public override bool IsDone() => current == -1;
    }
}