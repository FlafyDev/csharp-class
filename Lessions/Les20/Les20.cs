using System;
using Unit4.CollectionsLib;

namespace Les20
{
    class Les20 : Lession
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

        public Node<int> DeleteLast(Node<int> first)
        {
            Node<int> p = first;
            if (p == null || p.GetNext() == null)
                return null;
            while (p.GetNext().GetNext() != null)
            {
                p = p.GetNext();
            }
            p.SetNext(null);
            return first;
        }

        public Node<int> DeleteFirst(Node<int> first)
        {
            return first.GetNext();
        }

        public Node<int> DeleteIndex(Node<int> first, int index)
        {
            Node<int> p = first;
            if (index == 0) return DeleteFirst(first);

            int currentIndex = 0;
            while (p != null)
            {
                if (currentIndex == index - 1)
                {
                    if (p.GetNext() != null)
                    {
                        p.SetNext(p.GetNext().GetNext());
                    }
                    else
                    {
                        p.SetNext(null);
                    }
                }
                currentIndex++;
                p = p.GetNext();
            }
            return first;
        }

        public Node<int> DeleteNum(Node<int> first, int num)
        {
            // Delete first nodes
            Node<int> newFirst = first;
            while (newFirst != null && newFirst.GetValue() == num)
                newFirst = DeleteFirst(newFirst);

            Node<int> p = newFirst;
            Node<int> prev = null;
            while (p != null)
            {
                if (p.GetValue() == num)
                    prev.SetNext(p.GetNext());
                else
                    prev = p;
                p = p.GetNext();
            }
            return newFirst;
        }

        public override void Main()
        {
            // Node<int> n6 = new Node<int>(13);
            // Node<int> n5 = new Node<int>(6, n6);
            // Node<int> n4 = new Node<int>(10, n5);
            // Node<int> n3 = new Node<int>(0, n4);
            // Node<int> n2 = new Node<int>(-9, n3);
            // Node<int> n1 = new Node<int>(88, n2);

            // BiList biList = CreateBiList(n1);
            // PrintNodeList(biList.ls1);
            // PrintNodeList(biList.ls2);


            Node<int> n6 = new Node<int>(1);
            Node<int> n5 = new Node<int>(1, n6);
            Node<int> n4 = new Node<int>(1, n5);
            Node<int> n3 = new Node<int>(1, n4);
            Node<int> n2 = new Node<int>(1, n3);
            Node<int> n1 = new Node<int>(1, n2);

            PrintNodeList(n1);
            Console.WriteLine("");

            PrintNodeList(DeleteNum(n1, 1));


            // Node<int> n5 = new Node<int>(4);
            // Node<int> n4 = new Node<int>(8, n5);
            // Node<int> n3 = new Node<int>(2, n4);
            // Node<int> n2 = new Node<int>(1, n3);
            // Node<int> n1 = new Node<int>(5, n2);
            // 
            // Node<int> newFirst = Move(n1, 2);

            // PrintNodeList(newFirst);
        }
    }
}
