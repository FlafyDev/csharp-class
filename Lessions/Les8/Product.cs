namespace Les8 {
  class Product {
    private int id;
    private double price;

    public Product(int id, double price) {
      this.id = id;
      this.price = price;
    }

    public virtual double GetDiscountPrice() {
      return this.price * 0.9;
    }

    public double GetPrice() {
      return this.price;
    }
  }
}
