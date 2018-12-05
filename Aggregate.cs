using System.Collections.Generic;

namespace IteratorPattern
{
    public abstract class Aggregate<T> where T : class
    {
        protected List<T> list;

        public Aggregate()
        {
            list = new List<T>();
        }

        public Aggregate(List<T> list)
        {
            this.list = list;
        }

        public void Add(T element)
        {
            list.Add(element);
        }

        public abstract Iterator<T> CreateIterator();

        public int Length => list.Count;

        public T Get(int index) => list[index];
    }
}