using System;
using Unit4.CollectionsLib;

namespace Les11 {
  class Les11 : Lession {
    public void RemoveThrees(Stack<int> stack) {
      Stack<int> tmp = new Stack<int>(); 

      while (!stack.IsEmpty()) {
        tmp.Push(stack.Pop());
      }
      stack.Push(tmp.Top());
      while (!tmp.IsEmpty()) {
        if (tmp.Top() != stack.Top()) {
          stack.Push(tmp.Top());
        }
        tmp.Pop();
      }
    }

    public override void Main() {
      Stack<int> stack = new Stack<int>();
      stack.Push(1);
      stack.Push(2);
      stack.Push(2);
      stack.Push(3);
      stack.Push(4);
      stack.Push(4);
      stack.Push(4);
      stack.Push(4);
      stack.Push(5);
      stack.Push(6);
      stack.Push(7);
      stack.Push(7);
      stack.Push(7);
      stack.Push(7);
      stack.Push(8);
      stack.Push(9);
      stack.Push(10);
      stack.Push(11);
      stack.Push(12);
      stack.Push(13);
      stack.Push(14);
      stack.Push(15);
      Console.WriteLine(stack);
      RemoveThrees(stack);
      Console.WriteLine(stack);
    }
  }
}
