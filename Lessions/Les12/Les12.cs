using Unit4.CollectionsLib;
using System;

namespace Les12
{
    class Les12 : Lession
    {
        public bool IsUp(Stack<int> s)
        {
            int curr = s.Pop();
            if (!s.IsEmpty())
            {
                if (!(curr < s.Top()))
                {
                    return false;
                }
            }
            return true;
        }

        public int MaxPair(Stack<int> s)
        {
            int highest = 0;
            while (!s.IsEmpty())
            {
                int cur = s.Pop();
                if (!s.IsEmpty())
                {
                    int newHighest = s.Top() + cur;
                    if (highest < newHighest)
                    {
                        highest = newHighest;
                    }
                }
            }
            return highest;
        }

        public void ChangeDirNumbers(Stack<int> s)
        {
            int prev = s.Pop();
            while (!s.IsEmpty())
            {
                int cur = s.Pop();
                if (!s.IsEmpty())
                {
                    int next = s.Top();
                    if ((prev < cur && next < cur) || (prev > cur && next > cur))
                    {
                        Console.WriteLine(cur);
                    }
                }
                prev = cur;
            }
        }

        public Stack<int> DeleteDuplicates(Stack<int> s)
        {
            Stack<int> s2 = new Stack<int>();
            Stack<int> s3 = new Stack<int>();
            int prev = s.Pop();
            s2.Push(prev);

            while (!s.IsEmpty())
            {
                if (prev != s.Top())
                {
                    prev = s.Pop();
                    s2.Push(prev);
                }
                else
                {
                    s.Pop();
                }
            }

            while (!s2.IsEmpty())
            {
                s3.Push(s2.Pop());
            }

            return s3;
        }

        public bool IsBracketBalanced(String str)
        {
            Stack<char> brackets = new Stack<char>();
            for (int i = 0; i < str.Length; i++)
            {
                char chr = str[i];
                switch (chr)
                {
                    case '[':
                    case '(':
                    case '{':
                        brackets.Push(chr);
                        break;
                    case ']':
                        if (brackets.IsEmpty() || brackets.Pop() != '[') return false;
                        break;
                    case ')':
                        if (brackets.IsEmpty() || brackets.Pop() != '(') return false;
                        break;
                    case '}':
                        if (brackets.IsEmpty() || brackets.Pop() != '{') return false;
                        break;
                }
            }

            return brackets.IsEmpty();
        }

        public void SwapString()
        {
            Console.Write("Enter: ");
            string input = Console.ReadLine();
            string[] inputSplit = input.Split(" ");
            Stack<char> stack = new Stack<char>();
            /* for (int i = 0; i < inputSplit.Length; i++) */
            for (int i = inputSplit.Length - 1; i >= 0; i--)
            {
                for (int j = 0; j < inputSplit[i].Length; j++)
                {
                    stack.Push(inputSplit[i][j]);
                }
                if (i != 0)
                    stack.Push(' ');
            }
            string str = "";
            while (!stack.IsEmpty())
            {
                str += stack.Pop();
            }
            Console.WriteLine(str);
        }

        public override void Main()
        {
            SwapString();
            Console.WriteLine(IsBracketBalanced("{(a + b) + c} * [ 2 * { 5 - a}]")); // T
            Console.WriteLine(IsBracketBalanced("q - (r - (s + 2)) * q)")); // F
            Console.WriteLine(IsBracketBalanced("[a + ]] * [b - {a * 3}] + (a -(i)")); // F
            Console.WriteLine(IsBracketBalanced("{1 + (a *4)} - ((2 + (3 -[5 + b])) / 2)")); // T


            Stack<int> stack = new Stack<int>();

            //
            stack.Push(9);
            stack.Push(9);
            stack.Push(9);
            stack.Push(6);
            stack.Push(6);
            stack.Push(6);
            stack.Push(6);
            stack.Push(5);
            stack.Push(5);
            stack.Push(5);
            stack.Push(4);
            stack.Push(4);
            stack.Push(4);
            stack.Push(4);

            Stack<int> stack2 = new Stack<int>();
            // 7 7
            stack2.Push(3);
            stack2.Push(7);
            stack2.Push(3);
            stack2.Push(7);
            stack2.Push(3);
            // 1 3
            /* stack.Push(1); */
            /* stack.Push(2); */
            /* stack.Push(3); */
            /* stack.Push(2); */
            /* stack.Push(1); */
            /* stack.Push(2); */
            /* stack.Push(0); */
            /* stack.Push(5); */
            /* stack.Push(8); */
            /* stack.Push(10); */
            ChangeDirNumbers(stack2);
            Console.WriteLine(stack);
            Console.WriteLine(DeleteDuplicates(stack));
        }
    }
}
