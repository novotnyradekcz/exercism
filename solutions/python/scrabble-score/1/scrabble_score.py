def score(word):
    sum = 0
    for letter in word.lower():
        match letter:
            case ("a"|"e"|"i"|"o"|"u"|"l"|"n"|"r"|"s"|"t"):
                sum += 1
            case ("d"|"g"):
                sum += 2
            case ("b"|"c"|"m"|"p"):
                sum += 3
            case ("f"|"h"|"v"|"w"|"y"):
                sum += 4
            case ("k"):
                sum += 5
            case ("j"|"x"):
                sum += 8
            case ("q"|"z"):
                sum += 10
    return sum
