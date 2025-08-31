def recite(start, take=1):
    numbers = ["No", "One", "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine", "Ten"]
    result = []
    for i in range(start, start - take, -1):
        line1 = numbers[i] + " green bottle"
        if i != 1:
            line1 += "s"
        line1 += " hanging on the wall,"
        line2 = "And if one green bottle should accidentally fall,"
        line3 = "There'll be " + numbers[i - 1].lower() + " green bottle"
        if i != 2:
            line3 += "s"
        line3 += " hanging on the wall."
        result.append(line1)
        result.append(line1)
        result.append(line2)
        result.append(line3)
        if take > 1 and i != start - take + 1:
            result.append("")
    return result