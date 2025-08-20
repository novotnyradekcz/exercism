#include "darts.h"

uint8_t score(coordinate_t position)
{
    float distance = sqrtf(position.x * position.x + position.y * position.y);
    if (distance > 10)
        return 0;
    if (distance > 5)
        return 1;
    if (distance > 1)
        return 5;
    return 10;
}