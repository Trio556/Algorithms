using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Algorithms.Implementation;

namespace Algorithms
{
    public class LinkedListFactory : IAlgorithmFactory
    {
        private readonly LinkedListAlgorithms[] _linkedListAlgorithms;

        public LinkedListFactory()
        {
            _linkedListAlgorithms = Enum.GetValues(typeof(LinkedListAlgorithms)).Cast<LinkedListAlgorithms>().ToArray();
        }

        public ISetup GetSetup()
        {
            while (true)
            {
                Console.WriteLine("Select Linked List Algorithm:");

                for (int i = 0; i < _linkedListAlgorithms.Count(); i++)
                {
                    Console.WriteLine(_linkedListAlgorithms[i]);
                }

                Console.Write("Please Select One:");
                var linkedListString = Console.ReadLine();
                LinkedListAlgorithms linkedList;

                if (!Enum.TryParse(linkedListString, out linkedList))
                    continue;

                return GetGraph(linkedList);
            }
        }

        private ISetup GetGraph(LinkedListAlgorithms linkedList)
        {
            switch (linkedList)
            {
                case LinkedListAlgorithms.SortedInsert:
                    return new Implementation.LinkedList.SortInsert.SortInsertSetup();
            }

            return null;
        }
    }
}
