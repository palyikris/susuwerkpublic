// task: Írjuk meg az n faktoriálisát kiszámoló programot.

public class Fakt {

    static int fact_rec(int num) {

        if (num < 0) {
            System.out.println("Negatív!!");
            return -1;
        }

        if (num == 1 || num == 0) {
            return 1;
        }

        return num * fact_rec(num - 1);
    }

    public static void main(String[] args) {
        System.out.println("Adj egy szamot!");
        int a = Integer.parseInt(System.console().readLine());

        // int prod = 1;

        // for (int i = 1; i < a + 1; i++) {
        // prod *= i;
        // }

        int prod = fact_rec(a);

        System.out.println("A(z) " + a + " faktorialisa: " + prod);

    }
}
