package point2d;

public class Point {
  double x;
  double y;

  public Point(double x, double y) {
    if (x < 0 || y < 0) {
      throw new IllegalArgumentException("x and y must be positive");
    }
    this.x = x;
    this.y = y;
  }

  public void move(double dx, double dy) {
    this.x += dx;
    this.y += dy;
  }

  public void mirror(Point p) {
    this.x = 2 * p.x - this.x;
    this.y = 2 * p.y - this.y;
  }

  public void distance(Point p) {
    double distance = Math.sqrt(Math.pow(p.x - this.x, 2) + Math.pow(p.y - this.y, 2));
    System.out.println(distance);
  }

}