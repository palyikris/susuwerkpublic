// #include <algorithm>
// #include <iostream>
// #include <string>
// #include <vector>
// #include "person.h"
// // kulonbseg a <vector> es a "vector" kozott: az elso a standard library, a masodik a mi headerunk

// struct Person {
//   std::string name;
//   double age;
//   int id;

// private:
//   std::vector<const Person *> friends;

// public:
//   Person(const std::string &n, double a, int i) {
//     name = n;
//     age = a;
//     id = i;
//   }

//   bool add_friend_checked(const Person *person) {
//     bool already_friend = is_friend(person);
//     if (!already_friend) {
//       add_friend(person);
//     }
//     return !already_friend;
//   }

//   void add_friend(const Person *person) { friends.push_back(person); }

//   bool is_friend(const Person *person) {
//     for (auto f : friends) {
//       if (f->id == person->id) {
//         return true;
//       }
//     }
//     return false;
//   }

//   friend std::vector<const Person *>
//   transitive_friends_list(const Person &person);
// };

// // Note, that if we have a const Person* in the friends member, we are forced to
// // give out const references
// std::vector<const Person *> transitive_friends_list(const Person &person) {
//   // depth first search with an explicit stack
//   std::vector<const Person *> stack;
//   std::vector<const Person *> seen;
//   // do not push person itself, we do not treat friend
//   // relation reflexive (so someone is not always the
//   // friend of her/himself)
//   for (const Person *f : person.friends) {
//     stack.push_back(f);
//   }
//   while (!stack.empty()) {
//     const Person *current = stack.back();
//     stack.pop_back();
//     // std::count looks at all elements, std::find stops at the first match, but
//     // that would mean we have to use iterators, and we are not there yet :P
//     const bool seen_already = std::count(seen.begin(), seen.end(), current);
//     if (!seen_already) {
//       seen.push_back(current);
//       for (const Person *f : current->friends) {
//         stack.push_back(f);
//       }
//     }
//   }
//   return seen;
// }

// int main() {
//   Person p1("Alice", 25, 1);
//   Person p2("Bob", 30, 2);
//   Person p3("Charlie", 35, 3);
//   Person p4("Dave", 40, 4);
//   Person p5("Eve", 45, 5);
//   Person p6("Frank", 50, 6);

//   p1.add_friend_checked(&p2);
//   p2.add_friend_checked(&p3);
//   p2.add_friend_checked(&p1); // this is back-edge, so there is a cycle in the
//                               // friendship graph
//   p2.add_friend_checked(&p6);
//   p3.add_friend_checked(&p6);
//   p4.add_friend_checked(&p5);

//   // transitive_friends_list(p1) should return [&p1, &p2, &p3, &p6], &p1 because
//   std::cout << "Friends of Alice:\n";
//   for (const Person *f : transitive_friends_list(p1)) {
//     std::cout << "  - " << f->name << '\n';
//   }
//   std::cout << "---\n";
//   // p2 has it in its list transitive_friends_list(p4) should return [&p5]
//   std::cout << "Friends of Dave:\n";
//   for (const Person *f : transitive_friends_list(p4)) {
//     std::cout << "  - " << f->name << '\n';
//   }
// }
