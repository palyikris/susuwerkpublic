#include <stdio.h>

int first()
{
    // todo: change value of variable using pointer
    int randomVar = 42;
    int *ptr = &randomVar;

    printf("Value of randomVar before: %d\n", randomVar);

    *ptr = 69;

    printf("Value of randomVar after: %d\n", randomVar);

    return 0;
}

int second()
{

    // todo: change the value of a pointer using a pointer then change the value of that pointer
    int randomVar = 42;
    int *ptr = &randomVar;
    int *ptr2 = &*ptr;
    *ptr2 = 420;
    int *ptr3 = &*ptr2;
    *ptr3 = 666;

    printf("Value of randomVar after: %d\n", randomVar);
}

int third()
{
    // todo: create a self-referencing pointer
    int num = 10;
    int num1 = 112233;
    int *ptr = &num;
    int *ptr1 = &num1;
    int **selfPtr = &ptr;
    int **selfPtr1 = &ptr1;

    printf("Value of num: %d\n", num);
    printf("Value of num using pointer: %d\n", *ptr);
    printf("Value of num using self-referencing pointer: %d\n", **selfPtr);
    printf("%d %d %d %d %d %d\n", num, sizeof(*ptr), sizeof(**selfPtr), num1, sizeof(*ptr1), sizeof(**selfPtr1));

    return 0;
}

int fourthHelper(int *arr, int length)
{
    int sum = 0;

    for (int i = 0; i < length; i++)
    {
        sum += *(arr + i);
        // prompt: pointer arithmetic: Adding the value of the current element to the sum variable
    }

    return sum;
}

int fourth()
{
    int randomArr[] = {1, 2, 3, 4, 5};
    int length = sizeof(randomArr) / sizeof(randomArr[0]);
    int sum = fourthHelper(randomArr, length);
    printf("Sum of array: %d\n", sum);
}

int main()
{
    first();
    second();
    third();
    fourth();

    return 0;
}
