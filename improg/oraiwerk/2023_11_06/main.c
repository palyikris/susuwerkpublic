#include <stdio.h>

int *changeVals(int *num1, int *num2)
{
    int temp = *num1;
    *num1 = *num2;
    *num2 = temp;
    return num1;
}

int main()
{
    int num1 = 0;
    int num2 = 1;
    printf("%d %d\n", num1, num2);
    changeVals(&num1, &num2);
    printf("%d %d\n", num1, num2);
}