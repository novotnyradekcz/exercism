#include "roman_numerals.h"

char *to_roman_numeral(unsigned int number)
{
    char *roman = (char *)malloc(16 * sizeof(char));
    roman[0] = '\0';
    char romans[] = {'M', 'm', 'D', 'd', 'C', 'c', 'L', 'l', 'X', 'x', 'V', 'v', 'I'};
    unsigned int arabics[] = {1000, 900, 500, 400, 100, 90, 50, 40, 10, 9, 5, 4, 1};
    int numbers = 13;
    int j = 0;
    for (int i = 0; i < numbers; i++)
    {
        while (number >= arabics[i])
        {
            if (romans[i] >= 'A' && romans[i] <= 'Z')
            {
                roman[j] = romans[i];
                j++;
            }
            else
            {
                switch (romans[i])
                {
                    case 'm':
                        roman[j] = 'C';
                        roman[j + 1] = 'M';
                        break;
                    case 'd':
                        roman[j] = 'C';
                        roman[j + 1] = 'D';
                        break;
                    case 'c':
                        roman[j] = 'X';
                        roman[j + 1] = 'C';
                        break;
                    case 'l':
                        roman[j] = 'X';
                        roman[j + 1] = 'L';
                        break;
                    case 'x':
                        roman[j] = 'I';
                        roman[j + 1] = 'X';
                        break;
                    case 'v':
                        roman[j] = 'I';
                        roman[j + 1] = 'V';
                        break;
                }
                j += 2;
            }
            number -= arabics[i];
        }
    }
    roman[j] = '\0';
    return roman;
}