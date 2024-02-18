class Program
{
    static void Main(string[] args)
    {
        Queue<int> queue = new();

        queue.Enqueue(6);
        queue.Enqueue(8);
        queue.Enqueue(10);
        queue.Enqueue(3);
        queue.Enqueue(1);
        queue.Enqueue(61);
        queue.Enqueue(33);

        System.Console.WriteLine(queue.Dequeue().data);
        System.Console.WriteLine(queue.Dequeue().data);
        System.Console.WriteLine(queue.Dequeue().data);
        System.Console.WriteLine(queue.Dequeue().data);

    }
}