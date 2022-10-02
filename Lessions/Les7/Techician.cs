namespace Les7 {
  class Techician : Employee {
    public int computers;

    public Techician(int years, int computers) : base(years) {
      this.computers = computers;
    }

    public override int GetScore() {
      return base.GetScore() + this.computers;
    }
  }
}
