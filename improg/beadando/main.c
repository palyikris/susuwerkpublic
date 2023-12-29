#include "my_utils.h"

#include <stdio.h>
#include <stdlib.h>
#include <time.h>

int intro()
{

    printf("Spiral Matrix\n");
    printf("This program will create a spiral matrix of size n x n\n");
    printf("Choose from below!\n");

    printf("1 -- Create a spiral matrix\n");
    printf("2 -- Load a spiral matrix\n");
    printf("3 -- Save a spiral matrix\n");
    printf("Print a spiral matrix\n");
    printf("5 -- Exit\n");
    printf("6 -- Guide\n");
    printf("Enter your choice: ");

    int choice;
    scanf("%d", &choice);

    return choice;
}

int main()
{

    int choice = intro();

    switch (choice)
    {
    case 1:
        printf("Enter the size of the matrix: \n");
        int n;
        scanf("%d", &n);

        printf("Enter starting direction: (t, b, r, l)\n");
        char direction;
        scanf(" %c", &direction);

        printf("Enter rotation direction: (cw, ccw)\n");
        char rotation[3];
        scanf("%s", &rotation);

        printf("Loading matrix creator...\n");
        printf("Creating a matrix...\n");
        generate_spiral_matrix(n, direction, rotation);
        break;

    case 2:
        printf("Loadin a matrix...\n");
        break;

    case 3:
        printf("Save a matrix...\n");
        break;

    case 4:
        printf("Printing a matrix...\n");
        break;

    case 5:
        printf("Exiting...\n");
        break;

    case 6:
        printf("Opening Guide...\n");
        break;
    }

    return 0;
}
