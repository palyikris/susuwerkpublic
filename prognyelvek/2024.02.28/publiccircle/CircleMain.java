package publiccircle;

import publiccircle.Circle;
import publiccircle.PublicCircle;

public class CircleMain {
  public static void main(String[] args) {
    PublicCircle c = new PublicCircle();
    double area = c.getArea();
    System.out.println("Area: " + area);
    c.x = 5;
    c.y = 2;
    c.r = 10;
    area = c.getArea();
    System.out.println("Area: " + area);

    Circle c2 = new Circle(5, 2, 10);
    area = c2.getArea();
    System.out.println("Area: " + area);
    // c2.SetR(0);
  }
}
