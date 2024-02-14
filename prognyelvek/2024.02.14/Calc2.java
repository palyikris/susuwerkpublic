// task: Készítsünk egy programot, amely kiszámolja két egész szám összegét, 
// task: különbségét, szorzatát, hányadosát, és az osztási maradékot is megadja. 
// task: Figyeljen a nullával való osztásra (ez esetben ne végezze el az osztást). 
// task: A két számot parancssori paraméterként kell megadni. Vizsgáljuk meg azt is, 
// task: hogy megfelelő számú parancssori paramétert adtunk–e át.

public class Calc2 {
    public static void main(String[] args) {

        if (args.length < 2) {
            System.out.println("Tul keves parameter!");
            return;
        }

        int a = Integer.parseInt(args[0]);
        int b = Integer.parseInt(args[1]);

        System.out.println("Osszeg: " + (a + b));
        System.out.println("Kulonbseg: " + (a - b));
        System.out.println("Szorzat: " + (a * b));
        if (b != 0) {
            System.out.println("Hanyados: " + (a / b));
            System.out.println("Maradek: " + (a % b));
        } else {
            System.out.println("Nem lehet 0-val osztani");
        }
    }
}
