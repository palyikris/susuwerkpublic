public class Skip {
    public static void main(String[] args) {
        int a = 42;
        System.out.println("The " + a + " is a number.");

        System.out.println("");

        System.out.println("What is your name?");
        String name = System.console().readLine();
        System.out.println("Hello, " + name + "!");

        System.out.println("");

        System.out.println("What is your age?");
        int age = Integer.parseInt(System.console().readLine());
        System.out.println("You are " + age + " years old.");

        System.out.println("");

        System.out.println("Product table?");
        int product = Integer.parseInt(System.console().readLine());

        for (int i = 1; i < 11; i++) {
            System.out.println(i + " * " + product + " = " + i * product);
        }

    }
}