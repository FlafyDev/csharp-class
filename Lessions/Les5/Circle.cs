namespace Les5 {
  class Circle {
    protected Point center;
    protected int radius;
    
    public Circle(Point center, int radius) {
      this.center = center;
      this.radius = radius;
    }

    public virtual double GetArea() {
      return Math.PI * Math.Pow(radius, 2);
    }

    public double GetPerimeter() {
      return 2 * Math.PI * radius;
    }

    public override string ToString() {
      string output = "";
      output += "The Circle:\n";
      output += $"The center of the circle: ({this.center.GetX()}, {this.center.GetY()})\n";
      output += $"The radius: {this.radius}\n";
      return output;
    }
  }
}
