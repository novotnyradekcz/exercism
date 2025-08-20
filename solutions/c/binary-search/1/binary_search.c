#include "binary_search.h"

const int *binary_search(int value, const int *arr, size_t length)
{
    int *result = (int *)arr;
    
    while (length > 0)
    {
        if (result[length / 2] == value)
            return (&(result[length / 2]));
        else if (result[length / 2] > value)
        {
            length /= 2;
        }
        else
        {
            length /= 2;
            result += length + 1;
        }
    }
    return (0);
}