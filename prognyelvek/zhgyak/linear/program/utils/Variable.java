package linear.program.utils;

public class Variable {

  private int lowerBound;
  private int upperBound;
  private String name;
  private int value;

  public int getLowerBound() {
    return lowerBound;
  }

  public int getUpperBound() {
    return upperBound;
  }

  public String getName() {
    return name;
  }

  public int getValue() {
    return value;
  }

  public void setValue(int value) {
    this.value = value;
  }

  private Variable(int lowerBound, int upperBound, String name) {
    this.lowerBound = lowerBound;
    this.upperBound = upperBound;
    this.name = name;
  }

  public int getRange() {
    return upperBound - lowerBound + 1;
  }

  public static Variable makeVar(int lowerBound, int upperBound, String name) {
    if (upperBound <= lowerBound) {
      throw new IllegalArgumentException("Variable range must be greater than 0");
    }
    return new Variable(lowerBound, upperBound, name);
  }

  @Override
  public String toString() {
    return name + ": " + value;
  }

}
