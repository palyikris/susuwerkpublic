package linear.program.utils;

import static check.CheckThat.*;
import static org.junit.jupiter.api.Assertions.*;
import org.junit.jupiter.api.*;
import org.junit.jupiter.api.condition.*;
import org.junit.jupiter.api.extension.*;
import org.junit.jupiter.params.*;
import org.junit.jupiter.params.provider.*;
import check.*;

public class VariableTest {

  @ParameterizedTest
  @CsvSource({
      "0, 10, x",
      "1, 10, y",
      "0, 9, z"
  })
  public void paramTest(int lowerBound, int upperBound, String name) {
    Variable var = Variable.makeVar(lowerBound, upperBound, name);
    assertEquals(lowerBound, var.getLowerBound());
    assertEquals(upperBound, var.getUpperBound());
    assertEquals(name, var.getName());
    assertEquals(upperBound - lowerBound + 1, var.getRange());
  }

  @ParameterizedTest
  @CsvSource({
      "1, 1, x",
      "1, -1, y"
  })
  public void paramTestBadBounds(int lowerBound, int upperBound, String name) {
    try {
      Variable.makeVar(lowerBound, upperBound, name);
      fail("Expected IllegalArgumentException");
    } catch (IllegalArgumentException e) {
      // test passes
    }
  }

}
