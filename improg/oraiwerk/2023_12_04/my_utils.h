#ifndef MY_UTILS_H
#define MY_UTILS_H

typedef enum Type
{
    BSC,
    MSC,
    PHD,
} Type_e;

typedef struct BscData
{
    int totalCourses;
} BscData_s;

typedef struct MscData
{
    int cumulativeCreditIndex;
} MscData_s;

typedef struct PhdData
{
    int highestImpactFactor;
    int erdosNumber;
} PhdData_s;

typedef union AdditionalData
{
    BscData_s bscData;
    MscData_s mscData;
    PhdData_s phdData;
} AdditionalData_u;

typedef struct Student
{
    int id;
    int age;
    double average;
    Type_e type;
} Student_s;

int get_id_of_highest_average(Student_s students[], int size);

#endif
