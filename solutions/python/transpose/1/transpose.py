def transpose(input):
    lines = input.split("\n")
    max_length = 0
    for line in lines:
        if len(line) > max_length:
            max_length = len(line)
    result = []
    for i in range(len(lines)):
        lines[i] += " " * (max_length - len(lines[i]))
    for i in range(len(lines)):
        for j in range(len(lines[i])):
            if i == 0:
                result.append(lines[i][j])
            else:
                result[j] += lines[i][j]
    if len(result) > 1:
        result[len(result) - 1] = result[len(result) - 1].rstrip()
        for i in range(len(result) - 2, -1, -1):
            if len(result[i + 1]) < len(result[i]):
                if len(result[i].rstrip()) > len(result[i][:len(result[i + 1])]):
                    result[i] = result[i].rstrip()
                else:
                    result[i] = result[i][:len(result[i + 1])]
    return "\n".join(result)
