#include "secret_handshake.h"

const char **commands(size_t number)
{
    size_t c = 0;
    size_t wink = 1;
    size_t double_blink = 2;
    size_t close_your_eyes = 4;
    size_t jump = 8;
    size_t reverse = 16;
    char command[4][20];
    char **result;
    if (wink & number)
    {
        strcpy(command[c], "wink");
        c++;
    }
    if (double_blink & number)
    {
        strcpy(command[c], "double blink");
        c++;
    }
    if (close_your_eyes & number)
    {
        strcpy(command[c], "close your eyes");
        c++;
    }
    if (jump & number)
    {

        strcpy(command[c], "jump");
        c++;
    }
    result = malloc(c * sizeof(char*));
    if (reverse & number)
    {
        for (size_t i = 0; i < c; i++)
        {
            result[i] = malloc(strlen((command[c - i - 1]) + 1) * sizeof(char));
            strcpy(result[i], command[c - i - 1]);
        }
    }
    else
    {
        for (size_t i = 0; i < c; i++)
        {
            result[i] = malloc(strlen((command[i]) + 1) * sizeof(char));
            strcpy(result[i], command[i]);
        }
    }
    return ((const char **)result);
}