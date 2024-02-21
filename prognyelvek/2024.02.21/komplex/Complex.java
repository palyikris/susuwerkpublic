public class Complex {
  double re, im;

  public Complex(double re, double im) {
    this.re = re;
    this.im = im;
  }

  public Complex add(Complex toAddComplex) {
    return new Complex(re + toAddComplex.re, im + toAddComplex.im);
  }

  public Complex sub(Complex toSubComplex) {
    return new Complex(re - toSubComplex.re, im - toSubComplex.im);
  }

  public Complex mul(Complex toMulComplex) {
    return new Complex(re * toMulComplex.re, im * toMulComplex.im);
  }
}