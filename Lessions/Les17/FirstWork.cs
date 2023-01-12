using System;
using Unit4.CollectionsLib;

namespace Les17
{
    static class FirstWork
    {
        public static int NodeSum(Node<int> node)
        {
            int sum = 0;
            while (node != null)
            {
                sum += node.GetValue();
                node = node.GetNext();
            }
            return sum;
        }

        public static int NodeLength(Node<int> node)
        {
            int length = 0;
            while (node != null)
            {
                length += 1;
                node = node.GetNext();
            }
            return length;
        }

        public static bool IsAllTrue(Node<bool> first)
        {
            Node<bool> p = first;
            while (p != null)
            {
                if (!p.GetValue()) return false;
                p = p.GetNext();
            }
            return true;
        }

        public static void PrintEven(Node<int> first)
        {
            Node<int> p = first;
            while (p != null)
            {
                if (p.GetValue() % 2 == 0)
                {
                    Console.WriteLine(p.GetValue());
                }
                p = p.GetNext();
            }
        }
    }
}
