using System;

namespace Les2 {
  class Les2 : Lession {
    private int Exact(string[] arr, int num) {
      int counter = 0;

      for (int i = 0; i < arr.Length; i++) {
        if (arr[i].Length == num) {
          counter++;
        }
      }

      return counter;
    }

    // Complexity O(n^3)
    private void ThreeFlashlights(Flashlight[] arr, int total) {
      for (int i = 0; i < arr.Length; i++) {
        for (int j = i+1; j < arr.Length; j++) {
          for (int k = j+1; k < arr.Length; k++) {
            if (arr[i].GetPrice() + arr[j].GetPrice() + arr[k].GetPrice() == total) {
              Console.WriteLine(arr[i].GetModel());
              Console.WriteLine(arr[j].GetModel());
              Console.WriteLine(arr[k].GetModel());
            }
          }
        }
      }
    }

    override public void Main() {
      // Testing for "ThreeFlashlights" function
      ThreeFlashlights(new Flashlight[] {
          new Flashlight("", 5),
          new Flashlight("", 1),
          new Flashlight("", 8),
          new Flashlight("", 4),
          new Flashlight("", 9),
          new Flashlight("", 4),
          new Flashlight("", 7),
          new Flashlight("", 2),
          new Flashlight("", 6),
      }, 10);
    }
  }
}

