package arrays;

class Array {

  public static void foo(int... args) {
    for (int num : args) {
      System.out.println(num);
    }
  }

  public static void main(String args[]) {
    int array[] = new int[10];
    for (int i = 0; i < array.length; i++) {
      array[i] = (i + 1) * (i + 1);
    }

    // {
    // int i = 0;
    // while (i < array.length) {
    // System.out.println(array[i]);
    // ++i;
    // }
    // }
    // ! for ciklus megerosebb, mint a while ciklus

    int[] copy = array;
    // prompt: uj pointer ami ugyanarra mutat, mint az array --> alias

    int[] clone = java.util.Arrays.copyOf(array, array.length);

    for (int num : array) {
      System.out.println(num);
    }
    // prompt: bejaro ciklus, for each ciklus

    foo(array);
    foo(1, 2, 3, 4, 5);

  }
}