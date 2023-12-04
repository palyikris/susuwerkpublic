#include "my_utils.h"

#include <stdio.h>
#include <stdlib.h>
#include <time.h>

int main()
{
    srand(time(NULL));

    Student_s students[] = {
        {1, 18, 2.34, BSC},
        {2, 19, 3.45, MSC},
        {3, 20, 4.56, BSC},
        {4, 21, 2.67, PHD},

    };

    int highest_average_id = get_id_of_highest_average(students, 10);

    printf("Highest average id: %d\n", highest_average_id);

    return 0;
}
