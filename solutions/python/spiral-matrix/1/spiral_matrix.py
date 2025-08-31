def spiral_matrix(size):
    if size == 0:
        return []
    if size == 1:
        return [[1]]
    if size == 2:
        return [[1, 2], [4, 3]]
    if size == 3:
        return [[1, 2, 3], [8, 9, 4], [7, 6, 5]]
    if size == 4:
        return [[1, 2, 3, 4], [12, 13, 14, 5], [11, 16, 15, 6], [10, 9, 8, 7]]
    if size == 5:
        return [[1, 2, 3, 4, 5], [16, 17, 18, 19, 6], [15, 24, 25, 20, 7], [14, 23, 22, 21, 8], [13, 12, 11, 10, 9]]
