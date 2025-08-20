#include "reverse_string.h"

#include <stdlib.h>

char *reverse(const char *value)
{
    int i = 0;
    while (value[i])
        i++;
    int l = i - 1;
    char *output = (char *)malloc((l + 2) * sizeof(char));
    while (i >= 0)
    {
        i--;
        output[l - i] = value[i];
    }
    output[l + 1] = '\0';
return (output);
}