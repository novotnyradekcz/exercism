def response(hey_bob):
    if len(hey_bob.strip()) > 0 and hey_bob.strip()[-1] == '?':
        if hey_bob.isupper():
            return "Calm down, I know what I'm doing!"
        return "Sure."
    if hey_bob.isupper():
        return "Whoa, chill out!"
    if hey_bob.isspace() or len(hey_bob) == 0:
        return "Fine. Be that way!"
    return "Whatever."
