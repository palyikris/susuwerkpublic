package linear.program.utils;

public class InEqualityConstraint extends Constraint {

  public InEqualityConstraint(int[] coeffs, int value) {
    super(coeffs, value);
  }

  @Override
  public String getCompareString() {
    return " <= ";
  }

  @Override
  public boolean compare(int a, int b) {
    return a <= b;
  }
}
