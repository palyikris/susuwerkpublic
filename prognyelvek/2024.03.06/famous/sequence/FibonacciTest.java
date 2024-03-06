package famous.sequence;

import static check.CheckThat.*;
import static org.junit.jupiter.api.Assertions.*;
import org.junit.jupiter.api.*;
import org.junit.jupiter.api.condition.*;
import org.junit.jupiter.api.extension.*;
import org.junit.jupiter.params.*;
import org.junit.jupiter.params.provider.*;
import check.*;

public class FibonacciTest {

  @Test
  public void baseRecursionCasesTest() {
    assertEquals(1, Fibonacci.fib(1));
    assertEquals(1, Fibonacci.fib(2));
  }

  @Test
  public void negativeInputTest() {
    assertThrows(IllegalArgumentException.class, () -> Fibonacci.fib(-1));
  }

  @Test
  public void firstTenFibonacciNumbersTest() {
    int[] expected = { 1, 1, 2, 3, 5, 8, 13, 21, 34, 55 };
    for (int i = 0; i < expected.length; i++) {
      assertEquals(expected[i], Fibonacci.fib(i + 1));
    }
  }

  @Test
  public void RandomBigNumberTest() {
    assertEquals(832040, Fibonacci.fib(30));
  }

}
