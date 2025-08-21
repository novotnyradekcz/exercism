#include "isogram.h"

namespace isogram {
    bool is_isogram(std::string phrase) {
        for (size_t i = 0; i < phrase.length(); i++)
        {
            for (size_t j = 0; j < phrase.length(); j++)
            {
                if (((phrase[i] >= 'A' && phrase[i] <= 'Z') || (phrase[i] >= 'a' && phrase[i] <= 'z')) && i != j && (phrase[i] == phrase[j] || phrase[i] == phrase[j] + 32 || phrase[i] + 32 == phrase[j]))
                    return (false);
            }
        }
        return (true);
    }
}  // namespace isogram
