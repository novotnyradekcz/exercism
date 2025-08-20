#include "raindrops.h"

char *convert(char result[], int drops)
{
    int i = 0;
    if (drops % 3 == 0)
    {
        result[i++] = 'P';
        result[i++] = 'l';
        result[i++] = 'i';
        result[i++] = 'n';
        result[i++] = 'g';
    }
    if (drops % 5 == 0)
    {
        result[i++] = 'P';
        result[i++] = 'l';
        result[i++] = 'a';
        result[i++] = 'n';
        result[i++] = 'g';
    }
    if (drops % 7 == 0)
    {
        result[i++] = 'P';
        result[i++] = 'l';
        result[i++] = 'o';
        result[i++] = 'n';
        result[i++] = 'g';
    }
    if (i == 0)
    {
        int j = 0;
        char buffer[8];
        while (drops > 0)
        {
            buffer[j++] = drops % 10 + '0';
            drops /= 10;
        }
        while (j > 0)
            result[i++] = buffer[--j];
    }
    result[i] = '\0';
    return(result);
}