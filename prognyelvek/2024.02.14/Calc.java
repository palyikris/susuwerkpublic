// task: Készítsünk programot, amely bekér két egész számot, és kiírja a köztük lévő egész számok felét. 
// task: A beolvasás során kapott szövegeket egész számmá az alábbi konverziós függvénnyel alakíthatjuk át.

public class Calc {
    public static void main(String[] args) {
        System.out.println("Mettol?");
        int a = Integer.parseInt(System.console().readLine());
        System.out.println("Meddig?");
        int b = Integer.parseInt(System.console().readLine());

        for (int i = a + 1; i < b; i++) {
            float frac = i / 2f;
            System.out.println(frac);
        }

    }
}
