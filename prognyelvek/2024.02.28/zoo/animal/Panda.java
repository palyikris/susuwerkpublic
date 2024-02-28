package zoo.animal;

public class Panda {
  public String name, location;
  public int age;

  public Panda(String name, String location) {
    this.name = name;
    this.location = location;
  }

  public Panda(String location, int age) {
    this.location = location;
    this.age = age;
    this.name = age + " years old foundling from " + location;
  }

  public void happyBirthday(int limitYear) {
    age++;
    if (age > limitYear) {
      System.out.println("Sent back to China!");
    }
    System.out.println("Name: " + name + ", age: " + age + ", location: " + location);
  }
}
