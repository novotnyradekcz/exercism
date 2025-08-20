#include "space_age.h"

float age(planet_t planet, int64_t seconds)
{
    float year = 0.0;
    switch (planet)
    {
        case MERCURY:
            year = 0.2408467;
            break;
        case VENUS:
            year = 0.61519726;
            break;
        case EARTH:
            year = 1.0;
            break;
        case MARS:
            year = 1.8808158;
            break;
        case JUPITER:
            year = 11.862615;
            break;
        case SATURN:
            year = 29.447498;
            break;
        case URANUS:
            year = 84.016846;
            break;
        case NEPTUNE:
            year = 164.79132;
            break;
        default:
            return -1;
    }
    return (float)seconds / year / EARTH_YEAR_SECONDS;
}