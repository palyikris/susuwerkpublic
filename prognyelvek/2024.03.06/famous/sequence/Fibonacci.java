package famous.sequence;

public class Fibonacci {
  public static int fib(int n) {
    if (n < 0)
      throw new IllegalArgumentException("n must be non-negative");

    if (n == 1) {
      return 1;
    } else if (n == 2) {
      return 1;
    } else {
      return fib(n - 1) + fib(n - 2);
    }
  }
}
