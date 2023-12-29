#include "my_utils.h"

#include <stdio.h>
#include <stdlib.h>

void generate_spiral_matrix(int n, char start, char rotation[3])
{
    int matrix[n][n];
    int value = 1;

    if (n % 2 == 0)
    {
    }
    else
    {
        matrix[n / 2][n / 2] = value;
        value++;

        int i = n / 2;
        int j = n / 2;

        while (value <= n * n)
        {
            int steps = 1;

            printf("n: %d, value: %d\n", n, value);

            if (start == 't')
            {
                if (rotation == "cw")
                {
                    i++;
                    matrix[i][j] = value;
                    value++;

                    // to the right
                    for (int k = 0; k < steps; k++)
                    {
                        printf("i: %d, j: %d\n", i, j);
                        j++;
                        matrix[i][j] = value;
                        value++;
                    }

                    steps++;

                    // down
                    for (int k = 0; k < steps; k++)
                    {
                        printf("i: %d, j: %d\n", i, j);
                        i++;
                        matrix[i + 1][j] = value;
                        value++;
                    }

                    // to the left
                    for (int k = 0; k < steps; k++)
                    {
                        printf("i: %d, j: %d\n", i, j);
                        j--;
                        matrix[i][j] = value;
                        value++;
                    }

                    steps++;
                    // up
                    for (int k = 0; k < steps; k++)
                    {
                        printf("i: %d, j: %d\n", i, j);
                        i--;
                        matrix[i][j] = value;
                        value++;
                    }
                }
                else
                {
                    i++;
                    matrix[i][j] = value;
                    value++;

                    // to the left
                    for (int k = 0; k < steps; k++)
                    {
                        printf("i: %d, j: %d\n", i, j);
                        j--;
                        matrix[i][j] = value;
                        value++;
                    }

                    steps++;

                    // down
                    for (int k = 0; k < steps; k++)
                    {
                        printf("i: %d, j: %d\n", i, j);
                        i++;
                        matrix[i + 1][j] = value;
                        value++;
                    }

                    // to the right
                    for (int k = 0; k < steps; k++)
                    {
                        printf("i: %d, j: %d\n", i, j);
                        j++;
                        matrix[i][j] = value;
                        value++;
                    }

                    steps++;

                    // up
                    for (int k = 0; k < steps; k++)
                    {
                        printf("i: %d, j: %d\n", i, j);
                        i--;
                        matrix[i][j] = value;
                        value++;
                    }
                }
            }

            if (start == 'b')
            {
                if (rotation == "cw")
                {
                    i--;
                    matrix[i][j] = value;
                    value++;

                    // to the right
                    for (int k = 0; k < steps; k++)
                    {
                        printf("i: %d, j: %d\n", i, j);
                        j++;
                        matrix[i][j] = value;
                        value++;
                    }

                    steps++;

                    // down
                    for (int k = 0; k < steps; k++)
                    {
                        printf("i: %d, j: %d\n", i, j);
                        i++;
                        matrix[i + 1][j] = value;
                        value++;
                    }

                    // to the left
                    for (int k = 0; k < steps; k++)
                    {
                        printf("i: %d, j: %d\n", i, j);
                        j--;
                        matrix[i][j] = value;
                        value++;
                    }

                    steps++;
                    // up
                    for (int k = 0; k < steps; k++)
                    {
                        printf("i: %d, j: %d\n", i, j);
                        i--;
                        matrix[i][j] = value;
                        value++;
                    }
                }
                else
                {
                    i--;
                    matrix[i][j] = value;
                    value++;

                    // to the left
                    for (int k = 0; k < steps; k++)
                    {
                        printf("i: %d, j: %d\n", i, j);
                        j--;
                        matrix[i][j] = value;
                        value++;
                    }

                    steps++;

                    // down
                    for (int k = 0; k < steps; k++)
                    {
                        printf("i: %d, j: %d\n", i, j);
                        i++;
                        matrix[i + 1][j] = value;
                        value++;
                    }

                    // to the right
                    for (int k = 0; k < steps; k++)
                    {
                        printf("i: %d, j: %d\n", i, j);
                        j++;
                        matrix[i][j] = value;
                        value++;
                    }

                    steps++;

                    // up
                    for (int k = 0; k < steps; k++)
                    {
                        printf("i: %d, j: %d\n", i, j);
                        i--;
                        matrix[i][j] = value;
                        value++;
                    }
                }
            }

            if (start == 'l')
            {
                if (rotation == "cw")
                {
                    j--;
                    matrix[i][j] = value;
                    value++;

                    // down
                    for (int k = 0; k < steps; k++)
                    {
                        printf("i: %d, j: %d\n", i, j);
                        i++;
                        matrix[i + 1][j] = value;
                        value++;
                    }

                    steps++;

                    // to the right
                    for (int k = 0; k < steps; k++)
                    {
                        printf("i: %d, j: %d\n", i, j);
                        j++;
                        matrix[i][j] = value;
                        value++;
                    }

                    // down
                    for (int k = 0; k < steps; k++)
                    {
                        printf("i: %d, j: %d\n", i, j);
                        i++;
                        matrix[i + 1][j] = value;
                        value++;
                    }


                    // to the left
                    for (int k = 0; k < steps; k++)
                    {
                        printf("i: %d, j: %d\n", i, j);
                        j--;
                        matrix[i][j] = value;
                        value++;
                    }

                    steps++;
                }
                else
                {
                    i++;
                    matrix[i][j] = value;
                    value++;

                    // to the left
                    for (int k = 0; k < steps; k++)
                    {
                        printf("i: %d, j: %d\n", i, j);
                        j--;
                        matrix[i][j] = value;
                        value++;
                    }

                    steps++;

                    // down
                    for (int k = 0; k < steps; k++)
                    {
                        printf("i: %d, j: %d\n", i, j);
                        i++;
                        matrix[i + 1][j] = value;
                        value++;
                    }

                    // to the right
                    for (int k = 0; k < steps; k++)
                    {
                        printf("i: %d, j: %d\n", i, j);
                        j++;
                        matrix[i][j] = value;
                        value++;
                    }

                    steps++;

                    // up
                    for (int k = 0; k < steps; k++)
                    {
                        printf("i: %d, j: %d\n", i, j);
                        i--;
                        matrix[i][j] = value;
                        value++;
                    }
                }
            }

            if (start == 'r')
            {
                if (rotation == "cw")
                {
                }
                else
                {
                }
            }
        }
    }

    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < n; j++)
        {
            printf("%d\t", matrix[i][j]);
        }
        printf("\n");
    }
}