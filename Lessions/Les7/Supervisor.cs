namespace Les7 {
  class Superviser : Employee {
    public Employee[] supervisedEmployees;

    public Superviser(int years, Employee[] supervisedEmployees) : base(years) {
      /* this.supervisedEmployees = new Employee[15]; */
      this.supervisedEmployees = supervisedEmployees;
    }

    public override int GetScore() {
      int score = 0;
      for (int i = 0; i < this.supervisedEmployees.Length; i++) {
        score = this.supervisedEmployees[i].GetScore(); 
      }
      return score + base.GetScore();
    }
  }
}
