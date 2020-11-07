namespace Stack
{
    public class NodeStack
    {
        private Node head;
        public int Size { get; private set; }

        public void Push(int number)
        {
            Node node = new Node(number);
            node.Next = head;
            head = node;
            Size++;
        }
        public int Pop()
        {
            Node temp = head;
            head = head.Next;
            Size--;
            return temp.Data;
        }

        public int Back() => head.Data;

        public void Clear()
        {
            while(Size > 0)
                Pop();
        }

    }
}