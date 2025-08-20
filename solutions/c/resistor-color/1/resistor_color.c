#include "resistor_color.h"
#include <stdlib.h>

int color_code(resistor_band_t color)
{
    return (color);
}

resistor_band_t *colors()
{
    resistor_band_t *colors = malloc(10 * sizeof(resistor_band_t*));
    colors[0] = BLACK;
    colors[1] = BROWN;
    colors[2] = RED;
    colors[3] = ORANGE;
    colors[4] = YELLOW;
    colors[5] = GREEN;
    colors[6] = BLUE;
    colors[7] = VIOLET;
    colors[8] = GREY;
    colors[9] = WHITE;
    return (colors);
}