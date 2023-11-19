#include <stdio.h>
#include <string.h>

int first()
{
    int ints[5] = {1, 5, 2, 4, 3};
    int max = 0;
    int maxIndex = 0;
    int minIndex = 0;

    for (int i = 0; i < sizeof(ints) / sizeof(ints[0]); i++)
    {
        if (max < ints[i])
        {
            max = ints[i];
            maxIndex = i;
        }
    }

    int min = max;

    for (int i = 0; i < sizeof(ints) / sizeof(ints[0]); i++)
    {
        if (min > ints[i])
        {
            min = ints[i];
            minIndex = i;
        }
    }

    ints[minIndex] = max;
    ints[maxIndex] = min;

    for (int i = 0; i < sizeof(ints) / sizeof(ints[0]); i++)
    {
        printf("%d\n", ints[i]);
    }

    return 0;
}

int second()
{
    printf("Gimme a string:\n");
    char string[1000];
    fgets(string, sizeof(string), stdin);
    int rowCounter = 0;

    for (int i = 0; i < sizeof(string) / sizeof(string[0]); i++)
    {
        if (string[i] == '\n')
        {
            rowCounter++;
        }
    }

    printf("The number of rows is: %d\n", rowCounter);

    return 0;
}

int third()
{
    printf("Gimme text: \n");
    char text[1000];
    fgets(text, sizeof(text), stdin);
    int vowelCount = 0;
    int consCount = 0;

    for (int i = 0; text[i] != '\0'; i++)
    {
        if (text[i] == 'a' || text[i] == 'e' || text[i] == 'i' || text[i] == 'o' || text[i] == 'u')
        {
            vowelCount++;
        }
        else if (text[i] != ' ' && text[i] != '\n' && text[i] != '\0')
        {
            consCount++;
        }
    }

    printf("Number of vowels: %d, number of consonants: %d\n", vowelCount, consCount);
}

int fourth()
{
    printf("Gimme string: \n");
    char string[1000];
    scanf("%s", string);
    int sum = strlen(string);

    printf("%d", sum);

    return 0;
}

int fifthHelper(int num)
{
    int divSum = 0;
    for (int i = 1; i < num; i++)
    {
        if (num % i == 0)
        {
            divSum += i;
        }
    }
    return divSum;
}

int fifth()
{

    int ints[4] = {220, 100, 283, 150};

    for (int i = 0; i < sizeof(ints) / sizeof(ints[0]) - 1; i++)
    {
        for (int j = i + 1; j < sizeof(ints) / sizeof(ints[0]); j++)
        {
            if (fifthHelper(ints[i]) == ints[j])
            {
                printf("yes");
                return 0;
            }
        }
    }

    printf("no");
    return 0;
}

int main()
{
    // first();
    // second();
    // third();
    // fourth();
    fifth();
    return 0;
}