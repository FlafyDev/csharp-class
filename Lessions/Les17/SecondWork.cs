using System;
using Unit4.CollectionsLib;

namespace Les17
{
    static class SecondWork 
    {
        public static bool FirstAndLastEqual(Node<int> first)
        {
            Node<int> p = first;
            Node<int> last = null;
            while (p != null)
            {
                last = p;
                p = p.GetNext();
            }
            return p.GetValue() == first.GetValue();
        }

        public static bool TwoEqualNeighbors(Node<int> first)
        {
            Node<int> p = first;
            Node<int> prev = null;
            while (p != null)
            {
                if (prev != null && prev.GetValue() == p.GetValue())
                {
                    return true;
                }

                prev = p;
                p = p.GetNext();
            }
            return false;
        }

        public static bool IsSorted(Node<int> first)
        {
            Node<int> p = first;
            Node<int> prev = null;
            while (p != null)
            {
                if (prev != null && prev.GetValue() < p.GetValue())
                {
                    return false;
                }

                prev = p;
                p = p.GetNext();
            }
            return true;
        }

        public static bool IsXYRepeatadly(Node<int> first)
        {
            Node<int> p = first;
            Node<int> prev = null;
            Node<int> prevPrev = null;
            while (p != null)
            {
                if (prevPrev != null && prevPrev.GetValue() != p.GetValue())
                {
                    return false;
                }

                prevPrev = prev;
                prev = p;
                p = p.GetNext();
            }
            return true;
        }
    }
}
