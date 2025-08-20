#include "square_root.h"

int square_root(int num)
{
    for (int i = 0; i<=num; i++)
    {
        if (i * i == num)
            return (i);
    }
    return (0);
}