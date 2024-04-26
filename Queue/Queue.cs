using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Queue
{
    public class Queue
    {
        int Rear, Front, MaxSize, count, position;
        int[] queue;

        public void CreateQueue(int size)
        {
            Rear = -1;
            Front = 0;
            MaxSize = size;
            queue = new int[size];
            count = 0;
            position = 0;
            Console.WriteLine("Queue Created");
        }

        public void Enqueue(int number)
        {
            Rear = (Rear+1)%MaxSize;
            count++;
            queue[Rear] = number;
            position++;
            Console.WriteLine("Element Added to queue");
        }

        public void Dequeue()
        {
            int temp = queue[Front];
            Front = (Front+1)%MaxSize;
            count--;
            position--;
        }

        public void PrintQueue() 
        {
            Console.Write("Elements in queue are ");
            int i = Front;
            int c = 0;
            while (c < position)
            {
                Console.Write(queue[i] + "  ");
                i = (i + 1) % MaxSize;
                c++;
            }
        }

        public void Peek()
        {
            Console.WriteLine($"Element at peek is {queue[Front]}");
        }

        public bool Contains(int value)
        {
            bool flag = false;
            for (int i = Front; i <= Rear; i++)
            {
                if (queue[i] == value)
                    flag = true;

            }
            if(flag == true)
                return true;
            else
                return false;
        }

        public void Clear()
        {
            while (position > 0)
            {
                Front = (Front + 1) % MaxSize;
                count--;
                position--;
            }
        }

        public void Count()
        {
            Console.WriteLine($"Total number of elements : {count}");
        }
        public bool IsFull()
        {
            if(position == MaxSize)
                return true;
            else 
                return false;
                
        }
        public bool IsEmpty()
        {
            if(position == 0) 
                return true;
            else 
                return false;
        }
    }
}
