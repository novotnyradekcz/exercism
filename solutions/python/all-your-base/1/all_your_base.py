def rebase(input_base, digits, output_base):
    if input_base < 2:
        raise ValueError("input base must be >= 2")
    if output_base < 2:
        raise ValueError("output base must be >= 2")
    for digit in digits:
        if digit < 0 or digit >= input_base:
            raise ValueError("all digits must satisfy 0 <= d < input base")
    if digits == [0] or digits == []:
        return [0]
    number = 0
    for i in range(len(digits) - 1, -1, -1):
        current = 1
        for j in range(i):
            current *= input_base
        number += (digits[len(digits) - i - 1] * current)
    output_digits = []
    while number > 0:
        output_digits.append(number % output_base)
        number //= output_base
    output_digits.reverse()
    if (output_digits == []):
        return [0]
    return output_digits
