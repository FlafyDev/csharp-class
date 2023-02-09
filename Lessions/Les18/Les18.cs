using System;
using Unit4.CollectionsLib;

namespace Les18
{
    class RangeNode
    {
        private int from;
        private int to;

        public RangeNode(int from, int to)
        {
            this.from = from;
            this.to = to;
        }

        public int GetTo()
        {
            return this.to;
        }

        public void SetTo(int to)
        {
            this.to = to;
        }

        public int GetFrom()
        {
            return this.from;
        }

        public void SetFrom(int from)
        {
            this.from = from;
        }
    }

    class Les18 : Lession
    {
        public Node<RangeNode> CreateRangeList(Node<int> first)
        {
            Node<int> p = first, next = first;
            Node<RangeNode> firstRange = new Node<RangeNode>(new RangeNode(p.GetValue(), 0));

            // Create "lastRange" so we can efficiently add more ranges from the last node to the new node.
            Node<RangeNode> lastRange = firstRange;

            while (p != null)
            {
                next = p.GetNext();

                // Enters the if block when a sequence ends. (Or when the list is about to end)
                if (next == null || next.GetValue() != p.GetValue() + 1)
                {
                    lastRange.GetValue().SetTo(p.GetValue());

                    // Only if the list isn't about to end, add another node and initialize the first number of the range.
                    if (next != null)
                    {
                        Node<RangeNode> newRange = new Node<RangeNode>(new RangeNode(next.GetValue(), 0));
                        lastRange.SetNext(newRange);
                        lastRange = newRange;
                    }
                }

                p = p.GetNext();
            }

            return firstRange;
        }

        // Similar to the above "CreateRangeList", but print to console instead of using RangeNode.
        public void PrintAllRanges(Node<int> first)
        {
            Node<int> p = first, next = first;

            Console.Write(p.GetValue() + ", ");

            while (p != null)
            {
                next = p.GetNext();

                if (next == null)
                    Console.WriteLine(p.GetValue());
                else if (next.GetValue() != p.GetValue() + 1)
                    Console.Write(p.GetValue() + "\n" + next.GetValue() + ", ");

                p = p.GetNext();
            }
        }

        public void CountPrintRanges(Node<int> first)
        {
            Node<int> p = first, next = first;
            int rangeCounter = 0;

            while (p != null)
            {
                next = p.GetNext();

                if (next == null || next.GetValue() != p.GetValue() + 1)
                    rangeCounter++;

                p = p.GetNext();
            }

            Console.WriteLine(rangeCounter);
        }

        public void PrintFirstAndLengthRanges(Node<int> first)
        {
            Node<int> p = first, next = first;
            int lengthCounter = 1;

            Console.Write(p.GetValue() + ", ");

            while (p != null)
            {
                next = p.GetNext();

                if (next == null)
                    Console.WriteLine(lengthCounter);
                else if (next.GetValue() != p.GetValue() + 1)
                {
                    Console.Write(lengthCounter + "\n" + next.GetValue() + ", ");
                    lengthCounter = 0;
                }
                lengthCounter++;

                p = p.GetNext();
            }
        }


        public override void Main()
        {
            Node<int> n11 = new Node<int>(200);
            Node<int> n10 = new Node<int>(103, n11);
            Node<int> n9 = new Node<int>(102, n10);
            Node<int> n8 = new Node<int>(101, n9);
            Node<int> n7 = new Node<int>(100, n8);
            Node<int> n6 = new Node<int>(20, n7);
            Node<int> n5 = new Node<int>(19, n6);
            Node<int> n4 = new Node<int>(12, n5);
            Node<int> n3 = new Node<int>(5, n4);
            Node<int> n2 = new Node<int>(4, n3);
            Node<int> n1 = new Node<int>(3, n2);


            Console.Write("\n1. Number of ranges: ");
            CountPrintRanges(n1);

            Console.WriteLine("\n2. Directly print all ranges: (first,length)");
            PrintFirstAndLengthRanges(n1);

            Console.WriteLine("\n3. Print all ranges with RandeNode: (first,end)");
            Node<RangeNode> p = CreateRangeList(n1);
            // Print the resulted Node<RangeNode> to check.
            while (p != null)
            {
                Console.WriteLine("<" + p.GetValue().GetFrom() + " " + p.GetValue().GetTo() + ">");
                p = p.GetNext();
            }

            Console.WriteLine("\nDirectly print all ranges: (first,end)");
            PrintAllRanges(n1);

        }
    }
}
