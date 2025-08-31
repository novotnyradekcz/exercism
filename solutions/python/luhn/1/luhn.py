class Luhn:
    def __init__(self, card_num):
        self.number = card_num.replace(" ", "")

    def valid(self):
        if len(self.number) <= 1 or not self.number.isnumeric():
            return False
        doubled = []
        for i in range(len(self.number) - 2, -1, -2):
            if 2 * int(self.number[i]) > 9:
                doubled.append(2 * int(self.number[i]) - 9)
            else:
                doubled.append(2 * int(self.number[i]))
        for i in range(len(self.number) - 1, -1, -2):
            doubled.append(int(self.number[i]))
        sum_of_num = sum(doubled)
        return sum_of_num % 10 == 0
