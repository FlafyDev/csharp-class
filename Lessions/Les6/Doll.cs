namespace Les6 {
  class Doll : Toy {
    private int accNums;
    private double accPrice;

    public Doll(string name, double basePrice, string color,
        int accNums, double accPrice)
      : base(name, basePrice, color) {
      this.accNums = accNums;
      this.accPrice = accPrice;
    }

    public double Price() {
      return this.basePrice + this.accPrice * this.accNums;
    } 
  }
}
