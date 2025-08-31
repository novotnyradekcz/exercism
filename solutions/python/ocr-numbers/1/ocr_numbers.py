def convert(input_grid):
    if len(input_grid) != 0 and len(input_grid) % 4 != 0:
        raise ValueError("Number of input lines is not a multiple of four")
    for line in input_grid:
        if len(line) != 0 and len(line) % 3 != 0:
            raise ValueError("Number of input columns is not a multiple of three")
    def recursiveRead(grid, result):
        if grid[0][:3] == " _ " and grid[1][:3] == "| |" and grid[2][:3] == "|_|" and grid[3][:3] == "   ":
            result += "0"
        elif grid[0][:3] == "   " and grid[1][:3] == "  |" and grid[2][:3] == "  |" and grid[3][:3] == "   ":
            result += "1"
        elif grid[0][:3] == " _ " and grid[1][:3] == " _|" and grid[2][:3] == "|_ " and grid[3][:3] == "   ":
            result += "2"
        elif grid[0][:3] == " _ " and grid[1][:3] == " _|" and grid[2][:3] == " _|" and grid[3][:3] == "   ":
            result += "3"
        elif grid[0][:3] == "   " and grid[1][:3] == "|_|" and grid[2][:3] == "  |" and grid[3][:3] == "   ":
            result += "4"
        elif grid[0][:3] == " _ " and grid[1][:3] == "|_ " and grid[2][:3] == " _|" and grid[3][:3] == "   ":
            result += "5"
        elif grid[0][:3] == " _ " and grid[1][:3] == "|_ " and grid[2][:3] == "|_|" and grid[3][:3] == "   ":
            result += "6"
        elif grid[0][:3] == " _ " and grid[1][:3] == "  |" and grid[2][:3] == "  |" and grid[3][:3] == "   ":
            result += "7"
        elif grid[0][:3] == " _ " and grid[1][:3] == "|_|" and grid[2][:3] == "|_|" and grid[3][:3] == "   ":
            result += "8"
        elif grid[0][:3] == " _ " and grid[1][:3] == "|_|" and grid[2][:3] == " _|" and grid[3][:3] == "   ":
            result += "9"
        else:
            result += "?"
        if len(grid[0]) == 3:
            if len(grid) == 4:
                return result
            else:
                result += ","
                return recursiveRead(grid[4:], result)
        else:
            return recursiveRead([grid[0][3:], grid[1][3:], grid[2][3:], grid[3][3:]] + grid[4:], result)
    return recursiveRead(input_grid, "")

