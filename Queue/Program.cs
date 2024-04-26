namespace Queue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the size of queue to be created");
            int size = Convert.ToInt32(Console.ReadLine());
            Queue q = new Queue();
            q.CreateQueue(size);
            int options;
            do
            {
                Console.WriteLine("\n");
                Console.WriteLine("Enqueue : 1");
                Console.WriteLine("Dequeue : 2");
                Console.WriteLine("Peek : 3");
                Console.WriteLine("Contains : 4");
                Console.WriteLine("Count : 5");
                Console.WriteLine("Clear : 6");
                Console.WriteLine("Print : 7");
                Console.WriteLine("Exit : 0");

                options = Convert.ToInt32(Console.ReadLine());

                switch (options)
                {
                    case 1:
                        if (!q.IsFull())
                        {
                            Console.WriteLine("Enter the number  : ");
                            int no = Convert.ToInt32(Console.ReadLine());
                            q.Enqueue(no);

                        }
                        else
                            Console.WriteLine("Queue is full");
                        break;

                    case 2:
                        if (!q.IsEmpty())
                        {
                            q.Dequeue();
                            Console.WriteLine($"Element Deleted from queue");
                        }
                            
                        else
                            Console.WriteLine("Queue is Empty");
                        break;

                    case 3:
                        q.Peek();
                        break;

                    case 4:
                        Console.WriteLine("Enter value to be searched");
                        int value = Convert.ToInt32(Console.ReadLine());
                        if (q.Contains(value))
                            Console.WriteLine("Element Found");
                        else
                            Console.WriteLine("Element Not Found");
                        break;

                    case 5:
                        q.Count();
                        break;

                    case 6:
                        q.Clear();
                        Console.WriteLine("All Elements are Deleted");
                        break;

                    case 7:
                        if (!q.IsEmpty())
                            q.PrintQueue();
                        else
                            Console.WriteLine("Queue is empty");
                        break;

                    case 0:
                        break;

                    default:
                        Console.WriteLine("Wrong Choice");
                        break;
                }
            } while (options != 0);
            
        }
            
            
            
            
        }
    }

