using Algorithms.Implementation;
using System;
using System.Linq;

namespace Algorithms
{
    public class GraphFactory : AlgorithmFactory
    {
        public GraphFactory() : base("Graph", typeof(GraphAlgorithms))
        {

        }

        public override ISetup GetSetup(string algorithmName)
        {
            GraphAlgorithms graph;

            if (Enum.TryParse(algorithmName, out graph))
            {
                switch (graph)
                {
                    case GraphAlgorithms.BreadthFirstTraversal:
                        return new Implementation.Graph.BreadthFirstTraversal.BreadthSetup();
                    case GraphAlgorithms.DepthFirstTraversal:
                        return new Implementation.Graph.DepthFirstTraversal.DepthSetup();
                }
            }

            return null;
        }
    }
}
