using System;
using System.Collections.Generic;

namespace IteratorPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = new List<string> {"1","2","3","4"};
            Aggregate<string> listForward = new ForwardAggregate<string>(list);
            Aggregate<string> listbackward = new BackwardAggregate<string>(list);

            Print(listForward.CreateIterator());
            Print(listbackward.CreateIterator());
        }

        static void Print(Iterator<string> iterator)
        {
            for(iterator.First(); !iterator.IsDone(); iterator.Next())
                Console.WriteLine(iterator.CurrentItem());
        }
    }
}
