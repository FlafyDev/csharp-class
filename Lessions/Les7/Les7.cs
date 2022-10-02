namespace Les7 {
  class Les7 : Lession {
    public static bool IsAccepted(Employee[] arr) {
      int score = 0;

      for (int i = 0; i < arr.Length; i++) 
      {
        Employee employee = arr[i];
        if (!(employee is Superviser) && !(employee is UnionMember)) {
          score += employee.GetScore(); 
        } else {
          score -= employee.GetScore();
        }
      }

      return score > 0;
    }

    public static bool IsAccepted(Object[] arr) {
      int score = 0;
      for (int i = 0; i < arr.Length; i++) 
      {
        Object employee = arr[i];
        if (employee is Employee)
        {
          if (!(employee is Superviser) && !(employee is UnionMember)) {
            score += ((Employee)employee).GetScore(); 
          } else {
            score -= ((Employee)employee).GetScore();
          }
        }
      }

      return score > 0;
    }

    public override void Main() {
      Console.WriteLine(IsAccepted(new Employee[]{
          new Employee(10),
          new Employee(9),
          new Techician(9, 4),
          new UnionMember(8, 3),
          new Superviser(17, new Employee[]{
            new Employee(1),
            new Employee(1),
            new Employee(1),
            new Employee(1),
            new Employee(1),
            new Employee(1),
            new Employee(1),
            new Employee(1),
            new Employee(1),
            new Employee(1),
            new Employee(1),
            new Employee(1),
            new Employee(1),
            new Employee(1),
            new Employee(1),
          }),
      }));
    }
  }
}
