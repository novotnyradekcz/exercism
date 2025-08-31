def encode(plain_text):
    encoded = plain_text.lower().translate(str.maketrans("abcdefghijklmnopqrstuvwxyz", "zyxwvutsrqponmlkjihgfedcba"))
    omitted = encoded.replace(".", "").replace(",", "").replace(" ", "").replace("    ", "")
    result = ""
    for idx in range(len(omitted)):
        result += omitted[idx]
        if idx != len(omitted) - 1 and idx % 5 == 4:
            result += " "
    return result


def decode(ciphered_text):
    return ciphered_text.translate(str.maketrans("abcdefghijklmnopqrstuvwxyz", "zyxwvutsrqponmlkjihgfedcba")).replace(" ", "")
