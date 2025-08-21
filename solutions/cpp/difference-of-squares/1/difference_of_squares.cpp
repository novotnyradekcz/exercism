#include "difference_of_squares.h"

namespace difference_of_squares {
    unsigned int sum_of_squares(unsigned int number)
    {
        unsigned int result = 0;
        for (unsigned int i = 1; i<=number; i++)
            result += i * i;
        return (result);
    }

    unsigned int square_of_sum(unsigned int number)
    {
        return ((number * (number + 1) / 2 * (number * (number + 1) / 2)));
    }

    unsigned int difference(unsigned int number)
    {
        return (square_of_sum(number) - sum_of_squares(number));
    }
}  // namespace difference_of_squares

