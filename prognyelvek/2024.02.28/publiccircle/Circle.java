package publiccircle;

public class Circle {
  private double x, y, r;

  public Circle(double x, double y, double r) {
    if (r <= 0) {
      throw new IllegalArgumentException("Radius must be positive");
    }
    this.x = x;
    this.y = y;
    this.r = r;
  }

  public double getArea() {
    return Math.PI * r * r;
  }

  public double GetX() {
    return x;
  }

  public double GetY() {
    return y;
  }

  public double GetR() {
    return r;
  }

  public void SetX(double x) {
    this.x = x;
  }

  public void SetY(double y) {
    this.y = y;
  }

  public void SetR(double r) {
    if (r <= 0) {
      throw new IllegalArgumentException("Radius must be positive");
    }
    this.r = r;
  }
}
