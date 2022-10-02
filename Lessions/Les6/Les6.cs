namespace Les6 {
  class Les6 : Lession {
    public override void Main() {
      Car car = new Car("MyCar", 200, "black", 2);
      Doll doll = new Doll("MyDoll", 150, "pink", 4, 15);

      Console.WriteLine($"The car's price: {car.Price()}");
      Console.WriteLine($"The doll's price: {doll.Price()}");
    }
  }
}
