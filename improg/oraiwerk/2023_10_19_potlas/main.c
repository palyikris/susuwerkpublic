#include <stdio.h>

int main()
{

    float z = 3.4;
    // prompt: explicitly convert z to int type
    int y = (int)z; // idea: using cast
    // example: (<type>)

    // printf("Egy egeszre kasztolt lebegopontos szam: %d\n", y);

    // prompt: getting input data:
    int a, b;
    printf("Gimme a num:\n");
    scanf("%d", &a); // prompt: & is a pointer to the original variable
    printf("Another one:\n");
    scanf("%d", &b);

    int sum;
    sum = a + b;

    printf("The sum of the inputs: %d", sum);

    // idea: no string but sets of characters --> string literals
    // example: char[] name = "Kristof"

    // idea: modifying string variables
    // example: strcpy(<name_of_variable>, <new_value>)

    // idea: fill array w zeros
    // example: memset(arr, 0, n*sizeOf()array[0])

    return 0;
}