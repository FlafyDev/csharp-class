using System;
using Unit4.CollectionsLib;
using static Les17.NewYearsWork;

namespace Les17
{

    class Les17 : Lession
    {
        /// Other

        public static bool IsUp(Node<int> node)
        {
            int prev = node.GetValue();
            node = node.GetNext();
            while (node != null)
            {
                if (node.GetValue() <= prev)
                {
                    return false;
                }
                prev = node.GetValue();
                node = node.GetNext();
            }
            return true;
        }

        public override void Main()
        {
            // Testing New Years
            Party party = new Party();

            party.AddPerson(new Person("Hello1", false, 5, false));
            party.AddPerson(new Person("Hello2", true, 5, false));
            party.AddPerson(new Person("Hello3", false, 8, true));
            party.AddPerson(new Person("Hello4", true, 5, false));
            party.AddPerson(new Person("Ido", true, 2, false));

            party.PrintDrinks(); // Should print 25
            Console.WriteLine(party.IsBetweenTwoPositive("Hello3")); // Should be True
            Console.WriteLine(party.IsBetweenTwoPositive("Ido")); // Should be False
            Console.WriteLine(party.IsBetweenTwoPositive("Hello2")); // Should be False
            Console.WriteLine(party.CountPositive()); // Should print 3 
            party.UpdatePositiveIfBetween();
            Console.WriteLine(party.IsBetweenTwoPositive("Hello3")); // Should be True
            party.UpdatePositive();
            // Node<int> n1 = new Node<int>(2);
            // Node<int> n2 = new Node<int>(5);
            // Node<int> n3 = new Node<int>(3);
            // Node<int> n4 = new Node<int>(2);
            // Node<int> n5 = new Node<int>(5);
            // Node<int> n6 = new Node<int>(3);
            // Node<int> n7 = new Node<int>(2);
            // Node<int> n8 = new Node<int>(5);
            // Node<int> n9 = new Node<int>(3);

            // n1.SetNext(n2);
            // n2.SetNext(n3);
            // n3.SetNext(n4);
            // n4.SetNext(n5);
            // n5.SetNext(n6);
            // n6.SetNext(n7);
            // n7.SetNext(n8);
            // n8.SetNext(n9);
            // Console.WriteLine(IsChainMasholasat(n1));
            /* Console.WriteLine(IsUp(n1)); */
            /* Console.WriteLine(NodeLength(n1)); */
            /* Console.WriteLine(NodeSum(n1)); */
        }
    }
}
