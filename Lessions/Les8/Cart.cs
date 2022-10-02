namespace Les8 {
  class Cart {
    private string name;
    private Product[] arr;
    private int current;

    public Cart(string name, Product[] arr) {
      this.name = name;
      this.arr = arr;
      this.current = 0;
    }
  }
}
