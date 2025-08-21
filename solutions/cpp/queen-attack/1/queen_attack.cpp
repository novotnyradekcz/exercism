#include "queen_attack.h"

namespace queen_attack {
    chess_board::chess_board(std::pair<int,int> white, std::pair<int,int> black)
    {
        if((white.first < 0 || white.second < 0 
        || black.first < 0 || black.second < 0)
        || (white.first > 7 || white.second > 7
        || black.first > 7 || black.second > 7)
        || (white == black))
        {
            throw std::domain_error("can not negative value");
        }
        w = white;
        b = black;
    }
    std::pair<int,int> chess_board::queen(type t) const
    {
        std::pair<int, int> result;
        switch(t)
            {
            case type::white:
                result = w;
                break;
            case type::black:
                result = b;
                break;
            }
        
        return result;
    }
    std::pair<int,int> chess_board::white() const
    {
        return queen(type::white);
    }
    std::pair<int,int> chess_board::black() const
    {
        return queen(type::black);
    }
    bool chess_board::can_attack() const
    {
        
        return white().first == black().first
        || white().second == black().second
        || abs(white().first - black().first) == abs(white().second - black().second);
        }
}  // namespace queen_attack
