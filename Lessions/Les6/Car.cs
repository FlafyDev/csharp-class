namespace Les6 {
  class Car : Toy {
    private int size;

    public Car(string name, double basePrice, string color, int size)
      : base(name, basePrice, color) {
      this.size = size;
    }

    public double Price() {
      return this.basePrice + this.size * 15;
    } 
  }
}
