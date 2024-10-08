#include <utility>


template <typename T>
void swap(T &a, T &b) {
    T temp = a;
    a = b;
    b = temp;
}

int main(){
    int a = 5;
    int b = 10;
    swap(a, b);
    return 0;
}