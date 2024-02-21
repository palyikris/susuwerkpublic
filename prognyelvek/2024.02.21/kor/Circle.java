public class Circle {
  double x;
  double y;
  double r;

  public Circle(double x, double y, double r) {
    this.x = x;
    this.y = y;
    this.r = r;
  }

  public void enlarge(double f) {
    this.r *= f;
  }

  public double getArea() {
    return Math.pow(r, 2) * Math.PI;
  }
}