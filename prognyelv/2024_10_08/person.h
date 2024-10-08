#include <string>
#include <iostream>

class Person {

  public:
    std::string name;
    double age;
    int ID;

    Person(const std::string &n, double a, int i) : name(n), age(a), ID(i) {
      std::cout << "Person created!" << std::endl;
    };

    bool is_friend(const Person& p);
};

