package famous.sequence;

public class TriangularNumbers {
  public static int getTriangularNumber(int index) {
    if (index < 1) {
      throw new IllegalArgumentException("Index must be greater than 0");
    }
    return index * (index + 1) / 2;
  }
}
