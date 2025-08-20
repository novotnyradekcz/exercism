#include "pangram.h"

bool is_pangram(const char *sentence)
{
    int counter = 0;
    if (sentence == NULL)
        return (false);
    for (char c = 65; c <= 90; c++)
    {
        for (size_t i = 0; i < strlen(sentence); i++)
        {
            if (sentence[i] == c || sentence[i] == c + 32)
            {
                counter++;
                break ;
            }
        }
    }
    if (counter == 26)
        return (true);
    return (false);
}