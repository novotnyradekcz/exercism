#include "pangram.h"

namespace pangram {
    bool is_pangram(std::string sentence) {
        int counter = 0;
        for (char c = 65; c <= 90; c++)
        {
            for (size_t i = 0; i < sentence.length(); i++)
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
}  // namespace pangram
