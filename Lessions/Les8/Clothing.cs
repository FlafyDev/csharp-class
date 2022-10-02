namespace Les8 {
  class Clothing : Product {
    private string fabric;
    private string color;

    public Clothing(int id, double price, string fabric, string color) : base(id, price) {
      this.fabric = fabric;
      this.color = color;
    }

    public override double GetDiscountPrice() {
      return base.GetDiscountPrice() - 10;
    }
  }
}
