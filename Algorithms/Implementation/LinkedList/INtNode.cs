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
