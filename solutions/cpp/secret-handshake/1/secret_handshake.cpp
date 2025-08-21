#include "secret_handshake.h"

namespace secret_handshake {
    std::vector<std::string>    commands(size_t number)
    {
        size_t wink = 1;
        size_t double_blink = 2;
        size_t close_your_eyes = 4;
        size_t jump = 8;
        size_t reverse = 16;
        std::vector<std::string> result;
        if (wink & number)
            result.push_back("wink");
        if (double_blink & number)
            result.push_back("double blink");
        if (close_your_eyes & number)
            result.push_back("close your eyes");
        if (jump & number)
            result.push_back("jump");
        if (reverse & number)
            std::reverse(result.begin(), result.end());
        return result;
    }
}  // namespace secret_handshake
