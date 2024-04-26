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
        int Rear, Front, MaxSize, count;
        int[] queue;

        public void CreateQueue(int size)
        {
            Rear = -1;
            Front = 0;
            MaxSize = size;
            queue = new int[size];
            count = 0;
            Console.WriteLine("Queue Created");
        }

        public void Enqueue(int number)
        {
            Rear++;
            count++;
            queue[Rear] = number;
            Console.WriteLine("Element Added to queue");
        }

        public void Dequeue()
        {
            int temp = queue[Front];
            Front++;
            count--;
        }

        public void PrintQueue() 
        {
            for(int i = Front; i <= Rear; i++)
            {
                Console.Write(queue[i] + " ");
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
            while (Rear >= Front)
            {
                Front++;
                count--;
            }
        }

        public void Count()
        {
            Console.WriteLine($"Total number of elements : {count}");
        }
        public bool IsFull()
        {
            if(Rear == MaxSize-1)
                return true;
            else 
                return false;
                
        }
        public bool IsEmpty()
        {
            if(Front > Rear) 
                return true;
            else 
                return false;
        }
    }
}
