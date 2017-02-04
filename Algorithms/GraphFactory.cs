using Algorithms.Algorithms;
using Algorithms.Algorithms.BreadthFirstTraversal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    public class GraphFactory : IAlgorithmFactory
    {
        private readonly GraphAlgorithms[] _graphAlgorithms;

        public GraphFactory()
        {
            _graphAlgorithms = Enum.GetValues(typeof(GraphAlgorithms)).Cast<GraphAlgorithms>().ToArray();
        }

        public ISetup GetSetup()
        {
            while (true)
            {
                Console.WriteLine("Select Graph Algorithm:");

                for (int i = 0; i < _graphAlgorithms.Count(); i++)
                {
                    Console.WriteLine(_graphAlgorithms[i]);
                }

                Console.Write("Please Select One:");
                var graphString = Console.ReadLine();
                GraphAlgorithms graph;

                if (!Enum.TryParse<GraphAlgorithms>(graphString, out graph))
                    continue;

                return GetGraph(graph);
            }
        }

        private ISetup GetGraph(GraphAlgorithms graph)
        {
            switch (graph)
            {
                case GraphAlgorithms.BreadthFirstTraversal:
                    return new BreadthSetup();
            }

            return null;
        }
    }
}
