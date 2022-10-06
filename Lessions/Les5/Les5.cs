using System;

namespace Les5 {
  class Les5 : Lession {
    public override void Main() {
      Cylinder cylinder = new Cylinder(new Point(100, 100), 1, 10);
      Console.WriteLine(cylinder.ToString());
      Console.WriteLine($"The area of the cylinder: {cylinder.GetArea()}");
      Console.WriteLine($"The volume of the cylinder: {cylinder.GetVolume()}");
      
      // 5
      // answer: No. A class that inherits a another cannot access its private properties.
    }
  }
}
