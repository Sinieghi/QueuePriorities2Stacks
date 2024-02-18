
// This queue is defined by entry order, so first element is the first to be dequeued
class Queue<T>
{
    public Node<T>? node = null;
    public Node<T>? node2 = null;

    public void Enqueue(T x)
    {
        Node<T> n = new()
        {
            data = x,
            next = node != null ? node : null
        };
        if (n == null) System.Console.WriteLine("Queue is full");
        else node = n;
    }
    public bool IsEmpty(Node<T> node)
    {
        return node == null;
    }
    public void Push(Node<T> n)
    {
        n.next = null;
        Node<T> nd = null;
        nd = new()
        {
            data = n.data,
            next = node2 == null ? null : node2
        };
        node2 = nd;
    }
    public Node<T> Pop(Node<T> node)
    {
        Node<T> nd = node;
        if (node == this.node) this.node = this.node.next;
        if (node == this.node2) this.node2 = this.node2.next;
        nd.next = null;
        return nd;
    }
    public Node<T> Dequeue()
    {
        //how is this working? When you want to delete based on highest priority and this priority
        //is based on entering order. Always when dequeue is called they gona check if stack 2 is empty and if is empty will be filled with stack 1 element
        //but for what reason? Using stack logic that the last element is the first-off, to maintain a Delete operation in O(1) you have to be pointing to the
        //first element, so thats why we use a second stack to hold all in order to be deleted in O(1) time.

        if (IsEmpty(node2))
        {
            if (IsEmpty(node))
            { System.Console.WriteLine("Queue is full"); return node2; }
            else
                while (!IsEmpty(node))
                    Push(Pop(node));
        }
        return Pop(node2);
    }


    public void Display()
    {
        Node<T> n = node;
        while (n != null)
        {
            System.Console.WriteLine(n.data);
            n = n.next;
        }
    }
}