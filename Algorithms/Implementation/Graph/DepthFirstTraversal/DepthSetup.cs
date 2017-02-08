using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Implementation.Graph.DepthFirstTraversal
{
    public class DepthSetup : ISetup
    {
        private DepthFirstTraversal _depth = null;
        private int _startingNode = 2;
        private const int _depthSize = 4;

        public void Run()
        {
            if (_depth == null)
                throw new NullReferenceException("Depth not setup.");

            _depth.Run(_startingNode);
        }

        public bool SetupAlgorithm()
        {
            Console.WriteLine("Depth First Traversal");
            Console.WriteLine("Inputs: (0, 1) (0, 2) (1, 2) (2, 0) (2, 3) (3, 3)");
            Console.WriteLine("Which Node do you want to Start on, default is 2? (0, 1, 2, 3)");

            _depth = new DepthFirstTraversal(_depthSize);
            _depth.Add(0, 1);
            _depth.Add(0, 2);
            _depth.Add(1, 2);
            _depth.Add(2, 0);
            _depth.Add(2, 3);
            _depth.Add(3, 3);

            var nodeString = Console.ReadLine();
            int.TryParse(nodeString, out _startingNode);
            return true;
        }
    }
}
