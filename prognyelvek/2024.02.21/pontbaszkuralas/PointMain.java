public class PointMain {
  public static void main(String[] args) {
    Point p = new Point(1, 2);
    System.out.println("(" + p.x + ", " + p.y + ")");
    p.move(2, 2);
    System.out.println("(" + p.x + ", " + p.y + ")");
  }
}
