using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Algorithms.Implementation;

namespace Algorithms
{
    public class LinkedListFactory : AlgorithmFactory
    {
        public LinkedListFactory() : base("Linked List", typeof(LinkedListAlgorithms))
        {

        }

        public override ISetup GetSetup(string algorithmName)
        {
            LinkedListAlgorithms linkedList;

            if (Enum.TryParse(algorithmName, out linkedList))
            {
                switch (linkedList)
                {
                    case LinkedListAlgorithms.SortedInsert:
                        return new Implementation.LinkedList.SortInsert.SortInsertSetup();
                }
            }

            return null;
        }
    }
}
