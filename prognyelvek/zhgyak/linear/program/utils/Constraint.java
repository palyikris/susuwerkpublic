package linear.program.utils;

import java.util.List;
import java.util.ArrayList;

public class Constraint {
  protected int[] coeffs;
  protected int value;
  private List<Variable> vars;

  public void setVars(List<Variable> vars) {
    if (coeffs.length != vars.size()) {
      throw new IllegalArgumentException("");
    }
  }

  public Constraint(int[] coeffs, int value) {
    this.coeffs = coeffs.clone();
    this.value = value;
    this.vars = new ArrayList<Variable>();
  }

  public boolean compare(int a, int b) {
    throw new UnsupportedOperationException("Not supported yet.");
  }

  public String getCompareString() {
    throw new UnsupportedOperationException("Not supported yet.");
  }

  public boolean checkConstraint(int[] values) {
    int result = 0;
    boolean invalidParam = false;

    if (invalidParam) {
      throw new IllegalArgumentException();
    }

    for (int i = 0; i < coeffs.length; i++) {
      result += coeffs[i] * values[i];
    }

    return compare(result, value);
  }

  @Override
  public String toString() {
    if (coeffs.length != vars.size()) {
      throw new IllegalStateException("");
    }
    StringBuilder sb = new StringBuilder();
    for(int i = 0; i < coeffs.s)
  }

}
