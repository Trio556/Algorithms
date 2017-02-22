namespace Algorithms.Implementation.LinkedList.SortInsert
{
    /// <summary>
    /// SortInsert acts as a self contained Singlerly Linked List but only implements Ascending Sorting
    /// </summary>
    public class SortInsert
    {
        public IntNode Head { get; private set; }
        
        /// <summary>
        /// Places the new node inside the head in ascending order
        /// </summary>
        /// <param name="newNode"></param>
        public void SortedInsert(IntNode newNode)
        {
            //If there is no data or the data in the newNode is less than the current heads Data
            if (Head == null || Head.Data >= newNode.Data)
            {
                //Make the current newNode next node the head since the value is less
                newNode.Next = Head;
                //The newNode is now the Head of the List
                Head = newNode;
                //return void to break execution
                return;
            }
            
            //Assign currentNode Head's reference (since it's on the heap)
            var currentNode = Head;

            //While the current node has a node next to it
            //And if that next nodes data is less than this new node
            while (currentNode.Next != null && currentNode.Next.Data < newNode.Data)
            {
                //Shift the current node down until the newNode is less than the next node or it's at the end
                //Assign Current node the next objects reference
                currentNode = currentNode.Next;
            }

            //After the while loop the next node should either be null or bigger then the new nodes data
            newNode.Next = currentNode.Next;

            //Assign the current node's next to the new node, which will affect the object contained in the head since
            //It has a reference to the same object
            currentNode.Next = newNode;
        }
    }
}
