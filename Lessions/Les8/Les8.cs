using System;

namespace Les8 {
  class Les8 : Lession {
    public double GetSavedPrice(Product[] arr) {
      double savedPrice = 0;

      for (int i = 0; i < arr.Length; i++) {
        savedPrice += arr[i].GetPrice() - arr[i].GetDiscountPrice();
      }

      return savedPrice;
    }

    public override void Main() {
      Console.WriteLine(GetSavedPrice(new Product[] {
        new Shirt(1, "fab", "white", 120, "XL"),
        new Book(2, 70, "cool-book", "joe"),
      }));
    }
  }
}
