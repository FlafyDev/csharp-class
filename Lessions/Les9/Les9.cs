using Unit4.CollectionsLib;
using System;

namespace Les9 {
  class Les9 : Lession {
    private int GetLength(Stack<int> stack) {
      Stack<int> tmp = new Stack<int>(); 
      int counter = 0;

      while (!stack.IsEmpty()) {
        tmp.Push(stack.Pop());
        counter++;
      }

      while (!tmp.IsEmpty()) {
        stack.Push(tmp.Pop());
      }

      return counter;
    }

    private double GetAverage(Stack<int> stack) {
      Stack<int> tmp = new Stack<int>(); 
      double sum = 0;
      int length = 0;

      while (!stack.IsEmpty()) {
        tmp.Push(stack.Pop());
        length++;
        sum += tmp.Top();
      }

      while (!tmp.IsEmpty()) {
        stack.Push(tmp.Pop());
      }

      return sum / length;
    }

    private Stack<int> GeneratePositiveStack(Stack<int> stack) {
      Stack<int> tmp = new Stack<int>(); 
      Stack<int> positiveStack = new Stack<int>(); 

      while (!stack.IsEmpty()) {
        tmp.Push(stack.Pop());
      }

      while (!tmp.IsEmpty()) {
        if (tmp.Top() > 0) {
          positiveStack.Push(tmp.Top());
        }
        stack.Push(tmp.Pop());
      }

      return positiveStack;
    }

    private void FlipStack(Stack<int> stack) {
      Stack<int> tmp = new Stack<int>(); 
      Stack<int> tmp2 = new Stack<int>(); 

      while (!stack.IsEmpty()) {
        tmp.Push(stack.Pop());
      }
      while (!tmp.IsEmpty()) {
        tmp2.Push(tmp.Pop());
      }
      while (!tmp2.IsEmpty()) {
        stack.Push(tmp2.Pop());
      }
    }

    private Stack<int> CloneStack(Stack<int> stack) {
      Stack<int> tmp = new Stack<int>(); 
      Stack<int> tmp2 = new Stack<int>(); 


      while (!stack.IsEmpty()) {
        tmp.Push(stack.Pop());
      }
      while (!tmp.IsEmpty()) {
        stack.Push(tmp.Top());
        tmp2.Push(tmp.Pop());
      }

      return tmp2;
    }

    private int GetLast(Stack<int> stack) {
      Stack<int> clone = CloneStack(stack);
      int last = 0;

      while (!clone.IsEmpty()) {
        last = clone.Pop();
      }

      return last;
    }

    private int GetValueAtIndex(Stack<int> stack, int index) {
      int length = GetLength(stack);
      Stack<int> clone = CloneStack(stack);

      for (int i = 0; !clone.IsEmpty(); i++) {
        if (i == index) {
          return clone.Top();
        } else {
          clone.Pop();
        }
      }
      throw new IndexOutOfRangeException();
    }

    public override void Main() {
      Stack<int> myStack = new Stack<int>(); 
      myStack.Push(8);
      myStack.Push(7);
      myStack.Push(-3);
      myStack.Push(19);
      myStack.Push(33);
      myStack.Push(91);
      
      Console.WriteLine("original stack: " + myStack);
      Console.WriteLine("length: " + GetLength(myStack));
      Console.WriteLine("average: " + GetAverage(myStack));
      Console.WriteLine("only positives: " + GeneratePositiveStack(myStack));
      
      Console.WriteLine("a clone of the original stuck: " + CloneStack(myStack));
      
      FlipStack(myStack);
      Console.WriteLine("flipped stack: " + myStack);
      FlipStack(myStack);
      
      Console.WriteLine("last value in the stack: " + GetLast(myStack));
      Console.WriteLine("value at index 2 in the stack: " + GetValueAtIndex(myStack, 2));
      Console.WriteLine("value at index 0 in the stack(stack.Top()): " + GetValueAtIndex(myStack, 0));
    }
  }
}
