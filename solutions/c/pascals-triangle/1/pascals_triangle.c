#include "pascals_triangle.h"
#include <stdlib.h>

void free_triangle(uint8_t **triangle, size_t rows)
{
    if (rows == 0)
    {
        free(triangle[0]);
        free(triangle);
        return ;
    }
    for (size_t i = 0; i < rows; i++)
        free(triangle[i]);
    free(triangle);
    triangle = 0;
}

uint8_t **create_triangle(size_t rows)
{
    uint8_t **triangle;
    if (rows == 0)
    {
        triangle = malloc(sizeof(uint8_t*));
        triangle[0] = malloc(sizeof(uint8_t));
        triangle[0][0] = 0;
        return triangle;
    }
    triangle = malloc(rows * sizeof(uint8_t*));
    triangle[0] = malloc(rows * sizeof(uint8_t));
    triangle[0][0] = 1;
    for (size_t i = 1; i < rows; i++)
        triangle[0][i] = 0;
    for (size_t i = 1; i < rows; i++)
    {
        triangle[i] = malloc(rows * sizeof(uint8_t));
        triangle[i][0] = 1;
        for (size_t j = 1; j < rows; j++)
            triangle[i][j] = triangle[i - 1][j - 1] + triangle[i - 1][j];
    }
    return (triangle);
}