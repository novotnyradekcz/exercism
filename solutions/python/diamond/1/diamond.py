def rows(letter):
    letters = "ABCDEFGHIJKLMNOPQRSTUVWXYZ"
    output = []
    for i in range(letters.index(letter) + 1):
        row = ""
        for j in range(letters.index(letter) - i):
            row += " "
        row += letters[i]
        if i != 0:
            for j in range(2 * i - 1):
                row += " "
            row += letters[i]
        for j in range(letters.index(letter) - i):
            row += " "
        output.append(row)
    if letter != letters[0]:
        for i in range(len(output) - 1):
            output.append(output[- 2 * (i + 1)])
    return output