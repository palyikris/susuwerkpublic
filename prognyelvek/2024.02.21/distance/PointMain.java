import java.util.ArrayList;

public class PointMain {
  public static void main(String args[]) {
    double distSum = 0;
    ArrayList<Point> listOfPoints = new ArrayList<>();

    if (args.length == 0) {
      System.out.println(distSum);
      return;
    }

    for (int i = 0; i < args.length - 1; i += 2) {
      double x = Double.parseDouble(args[i]);
      double y = Double.parseDouble(args[i + 1]);
      Point p = new Point(x, y);
      listOfPoints.add(p);
    }

    for (int i = 0; i < listOfPoints.size() - 1; i++) {
      distSum += listOfPoints.get(i).distance(listOfPoints.get(i + 1));
    }

    System.out.println("Sum Dist: " + distSum);
  }
}
