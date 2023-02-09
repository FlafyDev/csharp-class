
using System;
using Unit4.CollectionsLib;

namespace Les20
{
    class FourAndFive
    {
        public int NodeLength(Node<int> node)
        {
            int length = 0;
            while (node != null)
            {
                length += 1;
                node = node.GetNext();
            }
            return length;
        }

        public Node<int> AddToLastNode(Node<int> first, Node<int> add)
        {
            if (first == null) return add;
            Node<int> p = first;
            while (p.GetNext() != null)
            {
                p = p.GetNext();
            }
            p.SetNext(add);
            return first;
        }

        /* public BiList CreateBiList(Node<int> first) */
        /* { */
        /*     int length = NodeLength(first); */
        /*     Node<int> max = null; */
        /*     Node<int> min = null; */
        /*     Node<int> p = first; */
        /*  */
        /*     while (p != null) */
        /*     { */
        /*         Node<int> p2 = first; */
        /*         int val = p.GetValue(); */
        /*  */
        /*         int biggerThan = 0; */
        /*         while (p2 != null) */
        /*         { */
        /*             if (val > p2.GetValue()) */
        /*             { */
        /*                 biggerThan += 1; */
        /*             } */
        /*  */
        /*             p2 = p2.GetNext(); */
        /*         } */
        /*  */
        /*         if (biggerThan >= length / 2) */
        /*         { */
        /*             max = AddToLastNode(max, new Node<int>(val)); */
        /*         } */
        /*         else */
        /*         { */
        /*             min = AddToLastNode(min, new Node<int>(val)); */
        /*         } */
        /*  */
        /*         p = p.GetNext(); */
        /*     } */
        /*     return new BiList(max, min); */
        /* } */

        public void PrintNodeList(Node<int> first)
        {
            Node<int> p = first;
            while (p != null)
            {
                Console.WriteLine(p.GetValue());
                p = p.GetNext();
            }
        }

        public Node<int> Move(Node<int> first, int n)
        {
            Node<int> p = first;
            Node<int> beforeToMove = null;
            int length = NodeLength(first);
            int index = 0;

            while (p.GetNext() != null)
            {
                if (index == length - n - 1)
                {
                    beforeToMove = p;
                }
                p = p.GetNext();
                index++;
            }

            Node<int> firstToMove = beforeToMove.GetNext();
            beforeToMove.SetNext(null);
            p.SetNext(first);
            return firstToMove;
        }
    }
}
