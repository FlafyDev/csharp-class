using System;
using Unit4.CollectionsLib;

namespace Les14
{
    class Les14 : Lession
    {
        public void FillQueue(Queue<int> q, int inserted)
        {
            if (inserted == 10) return;
            inserted++;
            q.Insert(inserted);
            FillQueue(q, inserted);
        }

        public void FillQueue(Queue<int> q)
        {
            FillQueue(q, 0);
        }

        public int QueueLast(Queue<int> q)
        {
            int num = q.Remove();
            if (q.IsEmpty()) return num;
            return QueueLast(q);
        }

        public int QueueLast2Sum(Queue<int> q, int lastNum)
        {
            int num = q.Remove();
            if (q.IsEmpty()) return num + lastNum;
            return QueueLast2Sum(q, num);
        }

        public int QueueLast2Sum(Queue<int> q)
        {
            return QueueLast2Sum(q, 0);
        }

        public void ReverseQueueRecursion(Queue<int> q)
        {
            int num = q.Remove();
            if (!q.IsEmpty()) ReverseQueueRecursion(q);
            q.Insert(num);
        }

        public void ReverseQueueWithStack(Queue<int> q)
        {
            Stack<int> tmp = new Stack<int>();
            while (!q.IsEmpty())
            {
                tmp.Push(q.Remove());
            }
            while (!tmp.IsEmpty())
            {
                q.Insert(tmp.Pop());
            }
        }

        public override void Main()
        {
            // Bagrot 2014 - 15
            //
            // 1. Sum of all numbers in the Stack that can be divided by 6.
            // 2. Sod takes the sum of all the stacks inside the first
            //    queue and puts them in the second queue
            //
            // Sum of stack `s1`: 84
            // Sum of stack `s2`: 36
            //
            // qr = [84, 36]

            Queue<int> myQueue = new Queue<int>();
            FillQueue(myQueue);
            Console.WriteLine(myQueue);
            /* Console.WriteLine(QueueLast(myQueue)); */
            ReverseQueueWithStack(myQueue);
            ReverseQueueRecursion(myQueue);
            ReverseQueueRecursion(myQueue);
            Console.WriteLine(myQueue);
            Console.WriteLine(QueueLast2Sum(myQueue));
            /* Stack<int> myStack = new Stack<int>(); */
            /* myStack.Push(2); */
            /* myStack.Push(1); */
            /* myStack.Push(3); */
            /* myStack.Push(5); */
            /* myStack.Push(0); */
            /* PrintStackReversed(myStack); */
        }
    }
}
