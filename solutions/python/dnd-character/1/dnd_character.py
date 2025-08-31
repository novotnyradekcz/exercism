import random

def modifier(ability):
    return (ability - 10) // 2

class Character:
    __die = [1, 2, 3, 4, 5, 6]
    def __roll(self):
        dice = []
        for i in range(4):
            dice.append(random.choice(self.__die))
        dice.remove(min(dice))
        return sum(dice)
    def __init__(self):
        self.strength = self.__roll()
        self.dexterity = self.__roll()
        self.constitution = self.__roll()
        self.intelligence = self.__roll()
        self.wisdom = self.__roll()
        self.charisma = self.__roll()
        self.hitpoints = 10 + modifier(self.constitution)

    def ability(self):
        return random.choice([self.strength, self.dexterity, self.constitution, self.intelligence, self.wisdom, self.charisma])
