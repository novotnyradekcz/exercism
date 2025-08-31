def resistor_label(colors):
    numbers = ["black", "brown", "red", "orange", "yellow", "green", "blue", "violet", "grey", "white"]
    precision = {"grey": "0.05%", "violet": "0.1%", "blue": "0.25%", "green": "0.5%", "brown": "1%", "red": "2%", "gold": "5%", "silver": "10%"}
    if len(colors) == 5:
        number = (100 * numbers.index(colors[0]) + 10 * numbers.index(colors[1]) + numbers.index(colors[2])) * pow(10, numbers.index(colors[3]))
    elif len(colors) == 4:
        number = (10 * numbers.index(colors[0]) + numbers.index(colors[1])) * pow(10, numbers.index(colors[2]))
    else:
        number = numbers.index(colors[0])
    if (number >= 1000000):
        if number / 1000000 - number // 1000000 < 0.001:
            return str(int(number / 1000000)) + " megaohms ±" + precision[colors[-1]]
        return str(number / 1000000) + " megaohms ±" + precision[colors[-1]]
    if (number >= 1000):
        if number / 1000 - number // 1000 < 0.001:
            return str(int(number / 1000)) + " kiloohms ±" + precision[colors[-1]]
        return str(number / 1000) + " kiloohms ±" + precision[colors[-1]]
    if (len(colors) != 1):
        return str(number) + " ohms ±" + precision[colors[-1]]
    return str(number) + " ohms"