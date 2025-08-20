#include "kindergarten_garden.h"

static plant_t    translate_diagram(char letter)
{
    if (letter == 'C')
        return CLOVER;
    if (letter == 'G')
        return GRASS;
    if (letter == 'R')
        return RADISHES;
    return VIOLETS;
}

plants_t    plants(const char *diagram, const char *student)
{
    plants_t    students_plants;
    int    offset = 0;
    int    row_length = 0;
    while (diagram[row_length] != '\n')
    {
        row_length++;
    }
    if (!strcmp(student, "Bob"))
        offset = 2;
    else if (!strcmp(student, "Charlie"))
        offset = 4;
    else if (!strcmp(student, "David"))
        offset = 6;
    else if (!strcmp(student, "Eve"))
        offset = 8;
    else if (!strcmp(student, "Fred"))
        offset = 10;
    else if (!strcmp(student, "Ginny"))
        offset = 12;
    else if (!strcmp(student, "Harriet"))
        offset = 14;
    else if (!strcmp(student, "Ileana"))
        offset = 16;
    else if (!strcmp(student, "Joseph"))
        offset = 18;
    else if (!strcmp(student, "Kincaid"))
        offset = 20;
    else if (!strcmp(student, "Larry"))
        offset = 22;
    students_plants.plants[0] = translate_diagram(diagram[offset]);
    students_plants.plants[1] = translate_diagram(diagram[offset + 1]);
    students_plants.plants[2] = translate_diagram(diagram[offset + row_length + 1]);
    students_plants.plants[3] = translate_diagram(diagram[offset + row_length + 2]);
    return students_plants;
}