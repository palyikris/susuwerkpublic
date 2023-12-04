#include <stdio.h>

int main()
{
    int num1, num2, sum;

    printf("First num: ");
    scanf("%d", &num1);

    printf("Second num: ");
    scanf("%d", &num2);

    // prompt: getting sum
    sum = num1 + num2;

    FILE *file = fopen("sum.txt", "w");
    // prompt: opening file to write in it

    if (file == NULL)
    {
        // prompt: check if problem
        printf("we have a problem, sir");
        return 1;
    }

    // prompt: print sum to file
    fprintf(file, "Sum: %d", sum);

    // prompt: close file
    fclose(file);

    return 0;
}
