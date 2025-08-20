#include "allergies.h"

#include <stdbool.h>

bool is_allergic_to(allergen_t allergen, int score)
{
    int allergy;
    if (allergen == 0)
        allergy = 1;
    if (allergen == 1)
        allergy = 2;
    if (allergen == 2)
        allergy = 4;
    if (allergen == 3)
        allergy = 8;
    if (allergen == 4)
        allergy = 16;
    if (allergen == 5)
        allergy = 32;
    if (allergen == 6)
        allergy = 64;
    if (allergen == 7)
        allergy = 128;
    if ((allergy & score) == allergy)
        return true;
    else
        return false;
}

allergen_list_t get_allergens(int score)
{
    score %= 256;
    allergen_list_t allergen_list;
    int counter = 0;
    int allergy = 128;
    for (int i = 7; i >= 0; i--)
    {
        if (score >= allergy)
        {
            allergen_list.allergens[i] = true;
            counter++;
            score -= allergy;
        }
        else
        {
            allergen_list.allergens[i] = false;
        }
        allergy /= 2;
    }
    allergen_list.count = counter;
    
    return allergen_list;
}
