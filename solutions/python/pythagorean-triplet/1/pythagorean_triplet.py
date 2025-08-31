import math

def triplets_with_sum(number):
    results = []
    for i in range(number // 25, number // 3):
        for j in range(i, number // 2):
            if i * i + j * j == (number - i - j) * (number - i - j):
                results.append([i, j, (number - i - j)])
    return results
