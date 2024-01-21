#include "my_utils.h"

#include <stdio.h>
#include <stdlib.h>
#include <time.h>
#include <string.h>
#include <dirent.h>
#include <ctype.h>

int guide()
{
    printf("\n");
    printf("Guide\n");
    printf("\n");
    printf("This program is used to create spiral matrices with nxn dimensions.\n");
    printf("You can choose to create a matrix, load a matrix, save a matrix, print a matrix, or exit the program.\n");
    printf("\n");
    printf("Create a matrix\n");
    printf("This option will create a spiral matrix with nxn dimensions.\n");
    printf("You will be asked to enter the size of the matrix, the starting direction, and the rotation direction.\n");
    printf("The size of the matrix is the number of rows and columns.\n");
    printf("The starting direction is the direction the matrix will start filling in.\n");
    printf("The rotation direction is the direction the matrix will rotate after each side is filled.\n");
    printf("\n");
    printf("Load a matrix\n");
    printf("This option will load a matrix from a file.\n");
    printf("You will be asked to enter the filename.\n");
    printf("The file must be in the same directory as the program.\n");
    printf("\n");
    printf("Save a matrix\n");
    printf("This option will save the current matrix to a file.\n");
    printf("The filenames are generated automatically.\n");
    printf("In case of a matrix with 7x7 size, starting from top, and going clockwise, the filename will be \"spiral7tcw\".\n");
    printf("The file will be saved in the same directory as the program under the name you entered.\n");
    printf("\n");
    printf("Print a matrix\n");
    printf("This option will print the current matrix.\n");
    printf("The matrix will be printed in the console.\n");
    printf("\n");
    printf("Exit the program\n");
    printf("This option will exit the program.\n");
    printf("\n");
    printf("All of these options will be available to you in the main menu.\n");
    printf("When starting the program, this main menu will be displayed.\n");
    printf("You will be asked to enter a number corresponding to the option you want to choose.\n");
    printf("If you enter an invalid number, you will be asked to enter a number again.\n");
    printf("If you enter a valid number, the program will execute the option you chose.\n");
    printf("After the program executes the option, you will be asked to enter a number again.\n");
    printf("If you enter 5, the program will exit.\n");
    printf("\n");
    printf("Thank you for using Spiral Matrix!\n");
    printf("\n");
    printf("\n");

    return 0;
}
int intro()
{

    printf("Spiral Matrix\n");
    printf("This program will create a spiral matrix of size n x n\n");
    printf("Choose from below!\n");

    printf("1 -- Create a spiral matrix\n");
    printf("2 -- Load a spiral matrix\n");
    printf("3 -- Save a spiral matrix\n");
    printf("4 -- Print a spiral matrix\n");
    printf("5 -- Exit\n");
    printf("6 -- Guide\n");
    printf("Enter your choice: ");

    int choice;
    scanf("%d", &choice);

    return choice;
}

int main()
{
    int choice = 0;
    int valid = 0;

    int **matrix;
    int n;
    char direction;
    char rotation[4];
    int matrixCreated = 0;

    while (choice != 5)
    {

        choice = intro();

        switch (choice)
        {
        case 1:
            while (valid == 0)
            {

                if (matrix != NULL)
                {
                    free(matrix);
                }

                printf("Enter the size of the matrix: \n");
                int nIsValid = scanf("%d", &n);

                printf("Enter starting direction: (t, b, r, l)\n");
                int directionIsValid = scanf(" %c", &direction);

                printf("Enter rotation direction: (cw, ccw)\n");
                int rotationIsValid = scanf("%s", &rotation);

                printf("Loading matrix creator...\n");
                printf("Creating a matrix...\n");

                if (matrix != NULL && nIsValid == 1 && directionIsValid == 1 && rotationIsValid == 1 && (strcmp(rotation, "cw") == 0 || strcmp(rotation, "ccw") == 0) && (direction == 't' || direction == 'b' || direction == 'r' || direction == 'l'))
                {
                    valid = 1;
                }

                if (valid == 0)
                {
                    printf("Invalid input!\n");
                    printf("Please try again!\n");
                }
                else
                {
                    matrix = generate_spiral_matrix(n, direction, rotation);
                    matrixCreated = 1;
                }
            }
            break;

        case 2:
            printf("Enter the filename: \n");
            char filename[20];

            scanf("%s", filename);
            printf("Loading matrix...\n");
            for (int i = 0; i < strlen(filename); i++)
            {
                if (isdigit(filename[i]))
                {
                    n = filename[i] - '0';
                }
            }
            printf("%d\n", n);
            matrix = malloc(n * sizeof(int *));
            for (int i = 0; i < n; i++)
            {
                matrix[i] = malloc(n * sizeof(int));
            }
            int result = load_matrix(matrix, n, filename);
            matrixCreated = 1;
            if (result == 0)
            {
                printf("Matrix loaded successfully!\n");
            }
            else
            {
                printf("Matrix could not be loaded!\n");
            }
            break;
        case 3:
            if (matrixCreated == 1)
            {
                printf("Saving current matrix...\n");
                save_matrix(matrix, n, direction, rotation);
            }
            else
            {
                printf("No matrix to save!\n");
            }
            break;
        case 4:
            printf("Printing a matrix...\n");
            if (matrixCreated == 1)
            {
                print_matrix(matrix, n);
            }
            else
            {
                printf("No matrix to print!\n");
            }
            break;

        case 5:
            free(matrix);
            break;

        case 6:
            printf("Opening Guide...\n");
            guide();
            break;

        default:
            printf("Invalid choice!\n");
            break;
        }
    }

    printf("Exiting...\n");
    printf("Thank you for using Spiral Matrix!\n");

    return 0;
}
