using System;
using System.Collections.Generic;

namespace Algorithms.Implementation.Graph.DepthFirstTraversal
{
    /// <summary>
    /// A self contained Graph based Algorithm named DepthFirstTraversal
    /// </summary>
    public class DepthFirstTraversal
    {
        private readonly int _graphSize;
        private readonly List<int>[] _nodes;

        /// <summary>
        /// Sets up the graph for the algorith
        /// </summary>
        /// <param name="graphSize"></param>
        public DepthFirstTraversal(int graphSize)
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
        /// Executes the algorithm
        /// </summary>
        /// <param name="startingNode"></param>
        public void Run(int startingNode)
        {
            //Initialize Visited array to the graph's size
            var visited = new bool[_graphSize];

            //Start the recursive algorithm
            DepthRecursive(startingNode, visited);
        }

        /// <summary>
        /// Recursive method for looping through nodes using the Depth First Traversal
        /// </summary>
        /// <param name="node"></param>
        /// <param name="visited"></param>
        private void DepthRecursive(int node, bool[] visited)
        {
            //Mark the Node that it's on as visited
            visited[node] = true;

            //Print the current node to the screen
            Console.Write(node + " ");

            //Loop through adjacent nodes
            for (int i = 0; i < _nodes[node].Count; i++)
            {
                var next = _nodes[node][i];

                //If the node hasn't been visited recurse the method
                if (!visited[next])
                    DepthRecursive(next, visited);
            }
        }
    }
}
