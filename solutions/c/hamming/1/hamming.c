#include "hamming.h"
#include <string.h>

int compute(const char *lhs, const char *rhs)
{
    if (lhs == 0 || rhs == 0 || strlen(lhs) != strlen(rhs))
        return (-1);
    int dist = 0;
    for (size_t i=0; i<strlen(lhs); i++)
    {
        if (lhs[i] != rhs[i])
            dist++;
    }
    return (dist);
}