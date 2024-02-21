public class CircleMain {
  public static void main(String[] args) {
    Circle c = new Circle(0, 0, 3);
    System.out.println("Centre: (" + c.x + ", " + c.y + "), Radius: " + c.r);
    c.enlarge(4);
    System.out.println("Centre: (" + c.x + ", " + c.y + "), Radius: " + c.r);
    double area = c.getArea();
    System.out.println("Area: " + area);
  }
}
