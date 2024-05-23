package linear.program.utils;

public class EqualityConstraint extends Constraint {

  public EqualityConstraint(int[] coeffs, int value) {
    super(coeffs, value);
  }

  @Override
  public String getCompareString() {
    return " == ";
  }

  @Override
  public boolean compare(int a, int b) {
    return a == b;
  }
}
