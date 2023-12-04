#include "my_utils.h"

#include <stdio.h>
#include <stdlib.h>
#include <time.h>

int get_id_of_highest_average(Student_s students[], int size)
{

    int highest_average = 0;
    int highest_average_id = 0;

    for (int i = 0; i < size; i++)
    {
        if (students[i].average > highest_average)
        {
            highest_average = students[i].average;
            highest_average_id = students[i].id;
        }
    }

    return highest_average_id;
}