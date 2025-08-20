#include "bob.h"

#include <ctype.h>
#include <stdbool.h>
#include <string.h>

char *hey_bob(char *greeting)
{
    char greet[strlen(greeting) + 1];
    strcpy(greet, greeting);
    size_t i = strlen(greet);
    while (i > 0)
    {
        i--;
        if (!isspace(greet[i]))
            break;
        greet[i] = '\0';
    }
    i = 0;
    if (greet[i] == '\0')
        return ("Fine. Be that way!");
    while (i < strlen(greet))
    {
        if (!isspace(greet[i]))
            break;
        i++;
    }
    if (greet[i] == '\0')
        return ("Fine. Be that way!");
    i = 0;
    bool upper = false;
    while (i < strlen(greet))
    {
        if (isupper(greet[i]))
            upper = true;
        if (islower(greet[i]))
            break;
        i++;
    }
    if (greet[i] == '\0' && upper)
    {
        if (greet[i - 1] == '?')
            return ("Calm down, I know what I'm doing!");
        return ("Whoa, chill out!");
    }
    i = 0;
    while (i < strlen(greet))
        i++;
    if (greet[i - 1] == '?')
        return ("Sure.");
    return ("Whatever.");
}