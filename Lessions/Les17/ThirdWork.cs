using System;
using Unit4.CollectionsLib;

namespace Les17
{
    static class ThirdWork
    {
        public static int MaxSumOfSection(Node<int> first)
        {
            Node<int> p = first;
            int maxSum = 0;
            int currentSum = 0;

            while (p != null)
            {
                if (p.GetValue() == 0)
                {
                    if (currentSum > maxSum)
                    {
                        maxSum = currentSum;
                    }
                    currentSum = 0;
                }
                else
                {
                    currentSum += p.GetValue();
                }

                p = p.GetNext();
            }
            if (currentSum > maxSum)
            {
                maxSum = currentSum;
            }
            return maxSum;
        }


        public static bool IsChainMasholasat(Node<int> first)
        {
            Node<int> p = first;

            int length = FirstWork.NodeLength(first);
            if (length % 3 != 0) return false;
            int sectionLength = length / 3;

            Node<int> prev = first;

            int index = 0;
            while (p != null)
            {
                index++;
                if (index > sectionLength + 1)
                {
                    int diff = index - (sectionLength + 1);
                    if (diff > 0)
                    {
                        prev = prev.GetNext();
                    }

                    if (p.GetValue() != prev.GetValue())
                    {
                        return false;

                    }
                }
                p = p.GetNext();
            }
            return true;
        }

        public static void SharsaretNodes(Node<int> n)
        {
            int num = 0;
            int len = 1;
            while (n != null)
            {
                if (n.GetValue() == -9)
                {
                    Console.WriteLine(num);
                    len = 1;
                    num = 0;
                }
                else
                {
                    num += n.GetValue() * len;
                    len *= 10;
                }
                n = n.GetNext();
            }
        }

    }
}
