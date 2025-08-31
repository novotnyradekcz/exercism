def primes(limit):
    primes = list(range(2, limit + 1))
    for prime in primes:
        number = prime + prime
        while number <= limit:
            try:
                primes.remove(number)
            except ValueError:
                pass
            number += prime
    return primes
