return function(pos)
    if pos.row < 0 or pos.column < 0 or pos.row > 7 or pos.column > 7 then
        error("Invalid coordinates!")
    end

    local can_attack = function(second)
        return (
            pos.row == second.row or
            pos.column == second.column or
            math.abs(pos.row - second.row) == math.abs(pos.column - second.column)
        )
    end

    return {
        row = pos.row,
        column = pos.column,
        can_attack = can_attack
    }
end
