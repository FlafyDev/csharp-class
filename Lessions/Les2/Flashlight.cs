namespace Les2 {
  class Flashlight {
    private string model;
    private int price;

    public Flashlight(string model, int price) {
      this.model = model;
      this.price = price;
    }

    public void SetModel(string model) {
      this.model = model;
    }

    public void SetPrice(int price) {
      this.price = price;
    }

    public int GetPrice() {
      return price;
    }

    public string GetModel() {
      return model;
    }
  }
}
