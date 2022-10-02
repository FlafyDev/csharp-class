namespace Les8 {
  class Pants : Clothing {
    private int length;
    private int width;

    public Pants(int id, string fabric, string color, double price, int length, int width) : base(id, price, fabric, color) {
      this.length = length;
      this.width = width;
    }
  }
}
