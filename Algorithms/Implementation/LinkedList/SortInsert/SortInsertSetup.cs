using System;

namespace Algorithms.Implementation.LinkedList.SortInsert
{
    public class SortInsertSetup : ISetup
    {
        private SortInsert _sortInsert;

        public void Run()
        {
            if (_sortInsert == null)
                throw new NullReferenceException("Sort Insert cannot be null");

            Console.WriteLine("Running Sort Insert passing the following Values in the order presented");
            Console.WriteLine("5 10 7 3 1 9");
            Console.WriteLine();

            var newNode = new IntNode(5);
            _sortInsert.SortedInsert(newNode);
            newNode = new IntNode(10);
            _sortInsert.SortedInsert(newNode);
            newNode = new IntNode(7);
            _sortInsert.SortedInsert(newNode);
            newNode = new IntNode(3);
            _sortInsert.SortedInsert(newNode);
            newNode = new IntNode(1);
            _sortInsert.SortedInsert(newNode);
            newNode = new IntNode(9);
            _sortInsert.SortedInsert(newNode);

            var temp = _sortInsert.Head;
            while (temp != null)
            {
                Console.Write(temp.Data + " ");
                temp = temp.Next;
            }
        }

        public bool SetupAlgorithm()
        {
            Console.WriteLine("Creating a new Sort insert...");
            _sortInsert = new SortInsert();

            return true;
        }
    }
}
