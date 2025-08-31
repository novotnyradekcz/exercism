def largest_product(series, size):
    if size > len(series):
        raise ValueError("span must be smaller than string length")
    if size < 1:
        raise ValueError("span must not be negative")
    for digit in series:
        if digit not in "0123456789":
            raise ValueError("digits input must only contain digits")
    largest = 0
    for i in range(len(series) - size + 1):
        product = int(series[i])
        for j in range(size - 1):
            product *= int(series[i + j + 1])
        if product > largest:
            largest = product
    return largest
