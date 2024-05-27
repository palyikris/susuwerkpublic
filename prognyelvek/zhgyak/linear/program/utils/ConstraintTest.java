package linear.program.utils;

import static check.CheckThat.*;
import static org.junit.jupiter.api.Assertions.*;

import java.util.ArrayList;
import java.util.List;

import org.junit.jupiter.api.*;
import org.junit.jupiter.api.condition.*;
import org.junit.jupiter.api.extension.*;
import org.junit.jupiter.params.*;
import org.junit.jupiter.params.provider.*;
import check.*;

public class ConstraintTest {
  @ParameterizedTest
  @CsvSource({
    "[1,2], 90"
  })
  public void paramTwoCoeffs(int[] coeffs, int value) {
    List<Variable> vars = new ArrayList<Variable>();
    vars.add(Variable.makeVar(1, 2, "a"));
  }
}
