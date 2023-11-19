#include <stdio.h>

int main()
{
    // todo: fill array w given length w zeros
    int length;
    printf("Enter the length of the list: ");
    scanf("%d", &length); // prompt: asking for length of list

    int list[length]; // prompt: creating list
    for (int i = 0; i < length; i++)
    {
        list[i] = 0;
        // idea: filling up list w zeros via going thru its slots and puttin zeros in them
    }

    // prompt: printing out the zeros
    printf("List of %d zeros:\n", length);
    for (int i = 0; i < length; i++)
    {
        printf("%d ", list[i]);
    }
    printf("\n");

    // todo: adding the elements in an array
    int listForSum[5] = {1, 2, 3, 4};
    int sum = 0;
    for (int i = 0; i < sizeof(listForSum) / sizeof(listForSum[0]); i++)
    // prompt: this is how to get the length of the list
    {
        sum += listForSum[i];
    }
    printf("Sum of the elements in the array: %d", sum);
    printf("\n");

    // todo: print the second smallest element of an array
    int listForSecondSmallest[5] = {1, 3, 5, 2, 4};
    int smallest = 10000;
    int secSmallest = 10000;

    for (int i = 0; i < sizeof(listForSecondSmallest) / sizeof(listForSecondSmallest[0]); i++)
    {
        if (listForSecondSmallest[i] < smallest)
        {
            smallest = listForSecondSmallest[i];
        }

        if (listForSecondSmallest[i] < secSmallest && listForSecondSmallest[i] > smallest)
        {
            secSmallest = listForSecondSmallest[i];
        }
    }

    printf("The second smallest element of the array: %d", secSmallest);
    printf("\n");

    // todo: addition for second task: add another array and multiply
    int listForMult[4] = {2, 1, 3, 4};

    for (int i = 0; i < sizeof(listForSum) / sizeof(listForSum[0]); i++)
    {
        sum += listForSum[i] * listForMult[i];
    }
    printf("Sum of the elements in the array: %d", sum);
    printf("\n");

    // todo: rewrite the one above to print avg and calc w float
    float avg = 0.0;
    int numerator = 0;
    for (int i = 0; i < sizeof(listForSum) / sizeof(listForSum[0]); i++)
    {
        sum += listForSum[i] * listForMult[i];
        numerator++;
    }
    avg = sum / numerator;
    printf("The avege of these numbers: %f", avg);
    printf("\n");

    // todo: which string comes first alphabetically
    char string1[] = "bapple";
    char string2[] = "anana";

    int result = 0;

    for (int i = 0; i < sizeof(string1) / sizeof(string1[0]); i++)
    {
        if (string1[i] < string2[i])
        {
            result = 1;
            break;
        }
        else if (string1[i] > string2[i])
        {
            result = 2;
            break;
        }
    }

    printf("The %d. string comes first alphabetically.", result);
    printf("\n");

    // todo: count the number of characters in a string
    char string3[] = "kaja";
    int counter = 0;

    for (int i = 0; i < sizeof(string3) / sizeof(string3[0]); i++)
    {
        counter++;
    }

    printf("The number of characters in the string: %d", counter - 1);

    return 0;
}
