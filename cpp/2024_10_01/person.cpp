#include <algorithm>
#include <string>
#include <vector>

struct Person {
  std::string name;
  double age;
  int id;

  Person(const std::string& n, double a, int i) {
    name = n;
    age = a;
    id = i;
  }

  bool add_friend(Person* person) {
    if (is_friend(person)) {
      return false;
    }
    friends.push_back(person);
    return true;
  }

  private:
  std::vector<Person *> friends;

  public:
  bool is_friend(Person *person) {
    // Equivalence based on pointer equality
    //
    // [Indexing]
    // ==========================================================
    // for (std::size_t i = 0; i < friends.size(); ++i) {
    //   if (friends[i] == person) {
    //     return true;
    //   }
    // }
    // return false;
    // ==========================================================
    //
    // [Algorithm]
    // ==========================================================
    // return std::count(friends.begin(), friends.end(), person);
    //
    // [Range-based for loop]
    // ==========================================================
    // for (auto f : friends) {
    //   if (person == f) {
    //     return true;
    //   }
    // }
    // return false;
    // ==========================================================
    //
    // ----------------------------------------------------------
    // Equivalence based on id equality
    // ==========================================================
    // for (std::size_t i = 0; i < friends.size(); ++i) {
    //   if (friends[i]->id == person->id) {
    //     return true;
    //   }
    // }
    // return false;
    // ==========================================================
    // return std::count_if(friends.begin(), friends.end(),
    //                      [person](Person *p) { return person->id == p->id; });
    // ==========================================================

    for (auto f : friends) {
      if (f->id == person->id) {
        return true;
      }
    }
    return false;
  }

  // TODO: Implement the Person class
  // A Person should have a name and and age, and an id number
  // It should know its list of friends, and it should be able tell if another
  // Person is its friend or not. You should also implement function that lists
  // the transitive friend relationships of a person, so the results of this
  // function should be a list of Persons, who are freinds with the given
  // person, their friends and their friends etc.
};

std::vector<Person*> transitive_friends_list(const Person& person) {
  std::vector<Person*> stack;
  std::vector<Person*> seen;

  for(Person* p : person.friends) {
    stack.push_back(p);
  }

  while(!stack.empty()) {
    Person* p = stack.back();
    stack.pop_back();

    if (std::find(seen.begin(), seen.end(), p) == seen.end()) {
      seen.push_back(p);
      for (Person* f : p->friends) {
        stack.push_back(f);
      }
    }
  }

  return seen;
}

int main() {
  Person p1("Alice", 25, 1);
  Person p2("Bob", 30, 2);
  Person p3("Charlie", 35, 3);
  Person p4("Dave", 40, 4);
  Person p5("Eve", 45, 5);
  Person p6("Frank", 50, 6);

  p1.add_friend(&p2);
  p2.add_friend(&p3);
  p2.add_friend(&p1);
  p2.add_friend(&p6);
  p3.add_friend(&p6);
  p4.add_friend(&p5);

  // transitive_friends_list(p1) should return [&p1, &p2, &p3, &p6], &p1 because p2 has it in its list
  // transitive_friends_list(p4) should return [&p5]
}
