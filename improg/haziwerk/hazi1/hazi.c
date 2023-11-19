#include <stdio.h>

int main()
{
    PrintName();
    PrintSum(4, 5);
    PrintHW();
    return 0;
}

int PrintName()
{
    printf("Palyi Kristof\n");
    return 0;
}

int PrintSum(num1, num2)
{
    printf("%d\n", num1 + num2);
    return 0;
}

int PrintHW()
{
    printf("Hello\nWorld");
    return 0;
}