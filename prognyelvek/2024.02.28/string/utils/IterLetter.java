package string.utils;

public class IterLetter {
  private String s;

  public IterLetter(String s) {
    if (s == null) {
      throw new IllegalArgumentException("String cannot be null");
    }
    this.s = s;
  }

  int i = 0;

  public void printNext() {
    if (i < s.length()) {
      System.out.println(s.charAt(i));
      i++;
    } else {
      System.out.println();
    }
  }

  public void reset() {
    i = 0;
  }

  public boolean hasNext() {
    return i < s.length();
  }
}
