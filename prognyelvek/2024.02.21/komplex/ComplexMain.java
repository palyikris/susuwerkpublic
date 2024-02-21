public class ComplexMain {
  public static void main(String[] args) {
    Complex c1 = new Complex(1, 2);
    Complex c2 = new Complex(3, 4);
    Complex a = c1.add(c2);
    Complex s = c1.sub(c2);
    Complex m = c1.mul(c2);
    System.out.println("Add: (" + a.re + " " + a.im + ")");
    System.out.println("Sub: (" + s.re + " " + s.im + ")");
    System.out.println("Mul: (" + m.re + " " + m.im + ")");
  }
}
