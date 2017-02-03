using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Algorithms.BreadthFirstTraversal
{
    public class BreadthSetup : ISetup
    {
        private BreadthFirstTraversal _breadth = null;
        private int _startingNode = 2;

        public void Run()
        {
            if (_breadth == null)
                throw new NullReferenceException("Breadth not setup.");
        }

        public bool SetupAlgorithm()
        {
            Console.WriteLine("Breadth First Traversal");
            Console.WriteLine("Inputs: (0, 1) (0, 2) (1, 2) (2, 0) (2, 3) (3, 3)");
            Console.WriteLine("Which Node do you want to Start on, default is 2? (0, 1, 2, 3)");
            var nodeString = Console.ReadLine();

            if (!int.TryParse(nodeString, out _startingNode))
                return false;

            return true;
        }
    }
}
