def annotate(minefield):
    annotated = []
    for line in minefield:
        if len(line) != len(minefield[0]):
            raise ValueError('The board is invalid with current input.')
    for i in range(len(minefield)):
        line = ""
        for j in range(len(minefield[i])):
            if minefield[i][j] != '*' and minefield[i][j] != ' ':
                raise ValueError('The board is invalid with current input.')
            if minefield[i][j] == '*':
                line += '*'
                continue
            count = 0
            if i != 0:
                if (minefield[i - 1][j] == '*'):
                    count  += 1
            if i != len(minefield) - 1:
                if minefield[i + 1][j] == '*':
                    count  += 1
            if j != 0:
                if minefield[i][j - 1] == '*':
                    count  += 1
            if j != len(minefield[i]) - 1:
                if minefield[i][j + 1] == '*':
                    count  += 1
            if i != 0 and j != 0:
                if minefield[i - 1][j - 1] == '*':
                    count  += 1
            if i != 0 and j != len(minefield[i]) - 1:
                if minefield[i - 1][j + 1] == '*':
                    count  += 1
            if i != len(minefield) - 1  and j != 0:
                if minefield[i + 1][j - 1] == '*':
                    count  += 1
            if i != len(minefield) - 1 and j != len(minefield[i]) - 1:
                if minefield[i + 1][j + 1] == '*':
                    count  += 1
            if count == 0:
                line += ' '
            else:
                line += str(count)
        annotated.append(line)
    return annotated
                
