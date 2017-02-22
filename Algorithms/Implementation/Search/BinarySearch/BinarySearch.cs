namespace Algorithms.Implementation.Search.BinarySearch
{
    public class BinarySearch
    {
        private readonly int[] _sortedArray;

        public BinarySearch(int[] sortedArray)
        {
            _sortedArray = sortedArray;
        }

        /// <summary>
        /// Runs the algorithm Binary Search
        /// </summary>
        /// <param name="numberToFind"></param>
        /// <returns></returns>
        public int Run(int numberToFind)
        {
            return Search(0, _sortedArray.Length - 1, numberToFind);
        }

        /// <summary>
        /// Performs the Binary Search
        /// </summary>
        /// <param name="lowerIndex"></param>
        /// <param name="middleIndex"></param>
        /// <param name="numberToFind"></param>
        /// <returns></returns>
        private int Search(int lowerIndex, int middleIndex, int numberToFind)
        {
            //If the middle index is greater than the lower index then the number doesn't exist
            if (middleIndex >= lowerIndex)
            {
                //Find the new middle index
                int mid = lowerIndex + (middleIndex - lowerIndex) / 2;

                //If the middle is the number we are looking for return
                if (_sortedArray[mid] == numberToFind)
                    return _sortedArray[mid];

                //if the middle number is greater than the number to find then the number exists in the lower bound
                if (_sortedArray[mid] > numberToFind)
                    return Search(lowerIndex, mid - 1, numberToFind);

                //Since the current middle number is less than the number to find then the number is in the upper bound
                return Search(mid + 1, middleIndex, numberToFind);
            }

            //Number does not exist so return negative one
            return -1;
        }
    }
}
