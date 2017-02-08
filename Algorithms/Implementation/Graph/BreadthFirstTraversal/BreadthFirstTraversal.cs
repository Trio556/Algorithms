using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Implementation.Graph.BreadthFirstTraversal
{
    public class BreadthFirstTraversal
    {
        private readonly int _graphSize;
        private readonly List<int>[] _nodes;

        /// <summary>
        /// Sets up the graph for the algorith
        /// </summary>
        /// <param name="graphSize"></param>
        public BreadthFirstTraversal(int graphSize)
        {
            _graphSize = graphSize;
            _nodes = new List<int>[graphSize];

            for (int i = 0; i < _nodes.Length; i++)
            {
                _nodes[i] = new List<int>();
            }
        }

        /// <summary>
        /// Adds an adjacent node to an edge.
        /// </summary>
        /// <param name="edge"></param>
        /// <param name="adjacent"></param>
        public void Add(int edge, int adjacent)
        {
            _nodes[edge].Add(adjacent);
        }

        /// <summary>
        /// Performs the algorithm
        /// </summary>
        /// <param name="startingEdge"></param>
        public void Run(int startingEdge)
        {
            //Used to remove duplicates
            var visited = new bool[_graphSize];
            
            //Holds adjacent notes for the current node
            var queue = new Queue<int>();

            visited[startingEdge] = true;
            queue.Enqueue(startingEdge);

            //As long as there is adjacent edges that haven't been ran loop
            while (queue.Any())
            {
                //Dequeue the next adjacent node
                startingEdge = queue.Dequeue();
                
                Console.Write(startingEdge + " ");

                for (int i = 0; i < _nodes[startingEdge].Count(); i++)
                {
                    var adjacentNode = _nodes[startingEdge][i];

                    //If it's the first time to the node then visit it and enqueue the value
                    //If it's not the first time continue loop
                    if (!visited[adjacentNode])
                    {
                        visited[adjacentNode] = true;
                        queue.Enqueue(adjacentNode);
                    }
                }
            }
        }
    }
}
