namespace Les7 {
  class UnionMember : Employee {
    public int yearsInUnion;

    public UnionMember(int years, int yearsInUnion) : base(years) {
      this.yearsInUnion = yearsInUnion;
    }

    public override int GetScore() {
      return 2 * (base.GetScore() + this.yearsInUnion);
    }
  }
}
