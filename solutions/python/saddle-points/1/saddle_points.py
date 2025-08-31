def saddle_points(matrix):
    for row in matrix:
        if len(row) != len(matrix[0]):
            raise ValueError("irregular matrix")
    result = []
    for i in range(len(matrix)):
        for j in range(len(matrix[i])):
            min = matrix[i][j]
            for l in range(len(matrix)):
                if matrix[l][j] < min:
                    min = matrix[l][j]
            if matrix[i][j] == max(matrix[i]) and matrix[i][j] == min:
                result.append({"row": i + 1, "column": j + 1})
    return result
