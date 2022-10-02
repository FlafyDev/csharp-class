namespace Les5 {
  class Cylinder : Circle {
    protected int height;

    public Cylinder(Point center, int radius, int height) : base(center, height) {
      this.height = height;
    }

    public override double GetArea() {

      return 2 * base.GetArea() + base.GetPerimeter() * height;
    }

    public double GetVolume() {
      return base.GetArea() * height;
    }

    public override string ToString() {
      string output = "";
      output += "The Cylinder:\n";
      output += $"The center of the base: ({this.center.GetX()}, {this.center.GetY()})\n";
      output += $"The radius of the base: {this.radius}\n";
      output += $"Height: {this.height}\n";
      return output;
    }
  }
}
