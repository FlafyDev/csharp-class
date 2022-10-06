using System;

namespace Les1 {
  class Les1 : Lession {
    public int CountAbroad(Vacation[] vacations) {
      int counter = 0;
      for (int i = 0; i < vacations.Length; i++) {
        Vacation vacation = vacations[i];
        counter += Convert.ToInt32(vacation != null && vacation.IsAbroad());
      }
      return counter;
    }

    override public void Main() {
      Vacation[] vacations = new Vacation[]{
        new Vacation("Ido Eitach", 3, "Jerusalem", "Hotel Havevieem", false),
        new Vacation("Ido Eitach", 3, "France", "Hotel Havevieem", true),
      };

      Console.WriteLine(vacations[0]);
      Console.WriteLine(vacations[1]);
      Console.WriteLine(CountAbroad(vacations));
    }
  }
}
