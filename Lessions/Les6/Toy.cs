namespace Les6 {
  class Toy {
    protected string name;
    protected double basePrice;
    protected string color;

    public Toy(string name, double basePrice, string color) {
      this.name = name;
      this.basePrice = basePrice;
      this.color = color;
    }

    public void UpdatePrice(double percent) {
      this.basePrice *= percent/100;
    }
  }
}
