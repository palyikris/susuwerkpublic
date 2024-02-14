// task: Írjuk meg az n faktoriálisát kiszámoló programot.

public class Fakt {
    public static void main(String[] args) {
        System.out.println("Adj egy szamot!");
        int a = Integer.parseInt(System.console().readLine());

        int prod = 1;

        for (int i = 1; i < a + 1; i++) {
            prod *= i;
        }

        System.out.println("A(z) " + a + " faktorialisa: " + prod);

    }
}
