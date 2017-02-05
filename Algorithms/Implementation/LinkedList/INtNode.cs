using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Implementation.LinkedList
{
    public class IntNode
    {
        public int Data { get; set; }
        public IntNode Next { get; set; }

        public IntNode(int data)
        {
            this.Data = data;
            Next = null;
        }
    }
}
