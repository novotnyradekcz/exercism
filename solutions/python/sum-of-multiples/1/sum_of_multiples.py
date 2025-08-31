def sum_of_multiples(limit, multiples):
    factors = set()
    for item in multiples:
        if item == 0:
            continue
        multiple = item
        while multiple < limit:
            factors.add(multiple)
            multiple += item
    return sum(factors)
