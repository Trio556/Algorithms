using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Algorithms.Implementation;

namespace Algorithms
{
    public class SortAndSearchFactory : AlgorithmFactory
    {
        public SortAndSearchFactory() : base("Sort and Search", typeof(SortAndSearchAlgorithms))
        {

        }

        public override ISetup GetSetup(string algorithmName)
        {
            SortAndSearchAlgorithms sortAndSearch;

            if (Enum.TryParse(algorithmName, out sortAndSearch))
            {
                switch (sortAndSearch)
                {
                    case SortAndSearchAlgorithms.BinarySearch:
                        return new Implementation.Search.BinarySearch.BinarySearchSetup();
                }
            }

            return null;
        }
    }
}
