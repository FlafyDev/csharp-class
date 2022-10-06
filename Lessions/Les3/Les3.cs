using System;

namespace Les3 {
  class Les3 : Lession {
    /* public static bool IsPerfect(int[] arr) { */
    /*   int counter = 0; */
    /*   int[] counters = new int[arr.Length]; */
    /*   do { */
    /*  */
    /*  */
    /*   } while (counter != 0 && ); */
    /* } */

    /* public static bool IsPerfect(int[] arr) */
    /* { */
    /*   int counter = 0; */
    /*   int index = 0; */
    /*   while (counter < arr.Length) { */
    /*     int newIndex = arr[index]; */
    /*     arr[index] = -1;  */
    /*     Console.WriteLine(index); */
    /*     index = newIndex; */
    /*     Console.WriteLine(index); */
    /*     if (index == -1) { */
    /*       return false; */
    /*     } */
    /*  */
    /*     counter += 1; */
    /*   } */
    /*  */
    /*   return counter == arr.Length; */
    /* } */

    // 6 LOC not including brackets.
    public static bool IsPerfect(int[] arr) 
    {
      int index = 0; // Will keep track of the index.
      // The for loop for traveling in the length of the array.
      for (int i = 0; i < arr.Length; i++) 
      {
        // When the next index is 0, return if we passed exactly the length of the array.
        index = arr[index];
        if (index == 0) 
        {
          return i == arr.Length - 1;
        }
      }
      return false;
    }

    override public void Main() {
      Console.WriteLine(IsPerfect(new int[]{
        3, 0, 1, 4, 2
      })); // True
      Console.WriteLine(IsPerfect(new int[]{
        1, 2, 5, 1, 3, 4
      })); // False
      Console.WriteLine(IsPerfect(new int[]{
        3, 4, 1, 5, 6, 0, 2
      })); // False
      Console.WriteLine(IsPerfect(new int[]{
        1, 2, 0, 2
      })); // False
      Console.WriteLine(IsPerfect(new int[]{
        1, 2, 3, 0
      })); // True
      Console.WriteLine(IsPerfect(new int[]{
        3, 2, 1, 4, 0
      })); // False
    }
  }
}

