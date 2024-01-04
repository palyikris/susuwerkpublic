#include "my_utils.h"

#include <stdio.h>
#include <string.h>
#include <stdlib.h>

void whileLoop(int **matrix, char start, char rotation[4], int n, int i, int j)
{

    // def: core of it all

    int steps = 1, value = 1, sidesDone = 0;
    char direction = start;
    int stop = 0;
    // prompt: declare and initialize variables

    while (value <= n * n && stop == 0)
    {

        // prompt: create a while loop that runs until value is greater than n*n --> whole matrix is filled
        switch (direction)
        {
        // prompt: create a switch statement that checks the direction
        case 't':
            for (int k = 0; k < steps; k++)
            {
                matrix[i][j] = value;
                value++;
                i--;
            }

            // prompt: create a for loop that runs for the number of steps

            if (strcmp(rotation, "cw") == 0)
            {
                direction = 'r';
            }
            else
            {
                direction = 'l';
            }

            // prompt: check if rotation is cw or ccw and change direction accordingly

            sidesDone++;

            if (sidesDone >= 2)
            {
                steps++;
                sidesDone = 0;
            }

            // prompt: check if two sides are done and increase steps by 1 and reset sidesDone to 0
            // prompt: its the same in all other cases

            break;

        case 'b':
            for (int k = 0; k < steps; k++)
            {
                matrix[i][j] = value;
                value++;
                i++;
            }
            if (strcmp(rotation, "cw") == 0)
            {
                direction = 'l';
            }
            else
            {
                direction = 'r';
            }
            sidesDone++;
            if (sidesDone >= 2)
            {
                steps++;
                sidesDone = 0;
            }
            break;

        case 'l':
            for (int k = 0; k < steps; k++)
            {
                matrix[i][j] = value;
                value++;
                j--;
            }
            if (strcmp(rotation, "cw") == 0)
            {
                direction = 't';
            }
            else
            {
                direction = 'b';
            }
            sidesDone++;
            if (sidesDone >= 2)
            {
                steps++;
                sidesDone = 0;
            }
            break;
        case 'r':
            for (int k = 0; k < steps; k++)
            {
                matrix[i][j] = value;
                value++;
                j++;
            }
            if (strcmp(rotation, "cw") == 0)
            {
                direction = 'b';
            }
            else
            {
                direction = 't';
            }
            sidesDone++;
            if (sidesDone >= 2)
            {
                steps++;
                sidesDone = 0;
            }
            break;

        default:

            // prompt: if direction is not t, b, l, or r, print invalid start position and set stop to 1 --> break out of while loop
            printf("Invalid start position\n");
            stop = 1;
            break;
        }
    }
}

int **generate_spiral_matrix(int n, char start, char rotation[4])
{
    int **matrix = (int **)malloc(n * sizeof(int *));
    // prompt: create a 2D array of size n x n

    for (int i = 0; i < n; i++)
    {
        matrix[i] = (int *)malloc(n * sizeof(int));
        // prompt: create a 2D array of size n x n
    }

    if (n % 2 != 0)
    {
        whileLoop(matrix, start, rotation, n, n / 2, n / 2);
    }
    // idea: if n is odd, start at the middle
    // idea: if n is even, starting point has 4 variations
    else
    {
        // prompt: create 4 if statements that check the starting position and call the while loop accordingly
        if ((start == 'b' && strcmp(rotation, "cw") == 0) || (start == 'l' && strcmp(rotation, "ccw") == 0))
        {
            whileLoop(matrix, start, rotation, n, n / 2 - 1, n / 2);
        }

        if ((start == 'l' && strcmp(rotation, "cw") == 0) || (start == 't' && strcmp(rotation, "ccw") == 0))
        {
            whileLoop(matrix, start, rotation, n, n / 2, n / 2);
        }

        if ((start == 'r' && strcmp(rotation, "cw") == 0) || (start == 'b' && strcmp(rotation, "ccw") == 0))
        {
            whileLoop(matrix, start, rotation, n, n / 2 - 1, n / 2 - 1);
        }

        if ((start == 't' && strcmp(rotation, "cw") == 0) || (start == 'r' && strcmp(rotation, "ccw") == 0))
        {
            whileLoop(matrix, start, rotation, n, n / 2, n / 2 - 1);
        }
    }

    return matrix;
}

int save_matrix(int **matrix, int n, char start, char rotation[4])
{
    FILE *fp;
    char filename[20];
    sprintf(filename, "spiral%d%c%s.txt", n, start, rotation);
    // prompt: create a filename using sprintf
    fp = fopen(filename, "w");
    if (fp == NULL)
    {
        return 1;
    }
    // prompt: open the file in write mode
    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < n; j++)
        {
            fprintf(fp, "%d\t", matrix[i][j]);
        }
        fprintf(fp, "\n");
    }
    // prompt: write the matrix to the file
    fclose(fp);
    return 0;
}

int load_matrix(int **matrix, int n, char filename[20])
{
    FILE *fp;
    fp = fopen(strcat(filename, ".txt"), "r");
    // prompt: open the file in read mode
    if (fp == NULL)
    {
        return 1;
    }
    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < n; j++)
        {
            fscanf(fp, "%d", &matrix[i][j]);
        }
    }
    // prompt: read the matrix from the file
    fclose(fp);
    return 0;
}

void print_matrix(int **matrix, int n)
{
    for (int i = 0; i < n; i++)
    {
        printf("\n");
        for (int j = 0; j < n; j++)
        {
            printf("%d\t", matrix[i][j]);
        }
    }
    // prompt: print the matrix with double for loops
    printf("\n");
}