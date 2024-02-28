package zoo.keeper;

import zoo.animal.Panda;

public class Crikey {
  public static void main(String[] args) {
    System.out.println("Crikey!");
    Panda prime = new Panda("Melbourne", 3);
    Panda newborn = new Panda("Wang Wang", "Adelaide");

    prime.happyBirthday(5);
    newborn.happyBirthday(5);

  }
}
