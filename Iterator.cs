using System.Collections.Generic;

namespace IteratorPattern
{
    public abstract class Iterator<T> where T : class
    {
        protected int current;
        protected Aggregate<T> list;

        public Iterator(Aggregate<T> list)
        {
            this.list = list;
        }

         public abstract void First();
         public abstract void Next();
         public abstract bool IsDone();
         public T CurrentItem()
         {
            if(IsDone())
                throw new System.Exception("Iterator out of bounds.");
            return list.Get(current);

         }
    }
}