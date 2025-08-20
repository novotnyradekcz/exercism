#include "isogram.h"
#include <string.h>

bool is_isogram(const char phrase[])
{
    if (phrase == 0)
        return (false);
    for (size_t i = 0; i<strlen(phrase); i++)
    {
        for (size_t j = 0; j<strlen(phrase); j++)
        {
            if (((phrase[i] >= 'A' && phrase[i] <= 'Z') || (phrase[i] >= 'a' && phrase[i] <= 'z')) && i != j && (phrase[i] == phrase[j] || phrase[i] == phrase[j] + 32 || phrase[i] + 32 == phrase[j]))
                return (false);
        }
    }
    return (true);
}