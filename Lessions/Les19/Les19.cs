using System;
using Unit4.CollectionsLib;

namespace Les19
{
    class MExp
    {
        public int num1;
        public char sign; // % / * - +
        public int num2;

        public MExp(int num1, char sign, int num2)
        {
            this.num1 = num1;
            this.sign = sign;
            this.num2 = num2;

        }

        public bool IsValid()
        {
            return !(num2 == 0 && (sign == '/' || sign == '%'));
        }

        public int Calculate()
        {
            if (!IsValid()) return 0;

            switch (sign)
            {
                case '+':
                    return num1 + num2;
                case '-':
                    return num1 - num2;
                case '*':
                    return num1 * num2;
                case '/':
                    return num1 / num2;
                case '%':
                    return num1 % num2;
                default:
                    throw new Exception("Unknown math operator");
            }
        }
    }

    class Les19 : Lession
    {
        public int SumExpressions(Node<MExp> first)
        {
            Node<MExp> p = first;
            int sum = 0;
            while (p != null)
            {
                sum += p.GetValue().Calculate();
                p = p.GetNext();
            }
            return sum;
        }

        public Node<double> NodeExpressions(Node<MExp> first)
        {
            Node<MExp> p = first;
            Node<double> newFirst = null;
            Node<double> newLast = null;
            while (p != null)
            {
                Node<double> newNode = new Node<double>(p.GetValue().Calculate());
                if (newFirst == null)
                {
                    newFirst = newLast = newNode;
                }
                else
                {
                    newLast.SetNext(newNode); newLast = newNode;
                }
                p = p.GetNext();
            }
            return newFirst;
        }

        public override void Main()
        {
            Node<MExp> n3 = new Node<MExp>(new MExp(10, '-', 7));
            Node<MExp> n2 = new Node<MExp>(new MExp(8, '/', 2), n3);
            Node<MExp> n1 = new Node<MExp>(new MExp(3, '+', 4), n2);

            Console.WriteLine(SumExpressions(n1));

            Node<double> first = NodeExpressions(n1);
            Node<double> p = first;
            while (p != null)
            {
                Console.WriteLine(p.GetValue());
                p = p.GetNext();
            }
        }
    }
}
