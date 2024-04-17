import java.util.HashSet;

class Program {

  private static String readLine() {
    return System.console().readLine();
  }

  public static void main(String[] args) {

    HashSet<String> osztaly;
    osztaly = new HashSet<String>();

    String nev = readLine();
    osztaly.add(nev);
    String nev1 = readLine();
    osztaly.add(nev1);
    String nev2 = readLine();
    osztaly.add(nev2);

    if (osztaly.contains("Kristóf")) {
      System.out.println("My class!");
    }

  }
}