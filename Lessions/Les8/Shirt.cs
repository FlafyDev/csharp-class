namespace Les8 {
  class Shirt : Clothing {
    private string size;

    public Shirt(int id, string fabric, string color, double price, string size) : base(id, price, fabric, color) {
      this.size = size;
    }
  }
}
