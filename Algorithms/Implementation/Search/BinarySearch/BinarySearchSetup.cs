using System;

namespace Algorithms.Implementation.Search.BinarySearch
{
    public class BinarySearchSetup : ISetup
    {
        private BinarySearch _search = null;
        private int _numberToFind;

        public void Run()
        {
            Console.WriteLine(_search.Run(_numberToFind));
        }

        public bool SetupAlgorithm()
        {
            Console.WriteLine("Searching supplied int array with values 2,3,7,10,14,20,30");

            var sortedArray = new int[] { 2, 3, 7, 10, 14, 20, 30};
            _search = new BinarySearch(sortedArray);

            Console.WriteLine("Please selected a number to search for, if the number doesn't exist in the array a -1 will be returned:");
            var input = Console.ReadLine();

            if (!int.TryParse(input, out _numberToFind))
                return false;

            return true;
        }   
    }
}
