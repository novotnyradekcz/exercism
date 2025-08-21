#include "reverse_string.h"

namespace reverse_string {
    std::string reverse_string(std::string word) {
        int length = word.length();
        for (int i = 0; i < length / 2; i++) {
            char temp = word[i];
            word[i] = word[length - 1 - i];
            word[length - 1 - i] = temp;
        }
        return word;
    }
}  // namespace reverse_string
