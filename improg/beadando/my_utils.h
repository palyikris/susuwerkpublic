#ifndef MY_UTILS_H
#define MY_UTILS_H

int **generate_spiral_matrix(int n, char start, char rotation[4]);
int save_matrix(int **matrix, int n, char start, char rotation[4]);
int load_matrix(int **matrix, int n, char filename[20]);
void print_matrix(int **matrix, int n);

#endif
