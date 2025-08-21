#include <string>

namespace log_line {
    std::string message(std::string line) {
        int message_start = line.find("]: ") + 3;
        int message_length = line.length() - message_start;
        return line.substr(message_start, message_length);
    }
    std::string log_level(std::string line) {
        int log_level_length = line.find("]: ") - 1;
        return line.substr(1, log_level_length);
    }
    std::string reformat(std::string line) {
        return message(line) + " (" + log_level(line) + ")";
    }
} // namespace log_line
