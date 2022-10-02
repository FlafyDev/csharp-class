namespace Les7 {
  class Employee {
    public int years;

    public Employee(int years) {
      this.years = years;
    }

    public virtual int GetScore() {
      return 4 + this.years;
    }
  }
}
