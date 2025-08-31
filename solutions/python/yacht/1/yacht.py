"""A function for calculating the score in a game of Yacht."""

# Score categories.
# Change the values as you see fit.
YACHT = "yacht"
ONES = 1
TWOS = 2
THREES = 3
FOURS = 4
FIVES = 5
SIXES = 6
FULL_HOUSE = "full house"
FOUR_OF_A_KIND = "four of a kind"
LITTLE_STRAIGHT = "little straight"
BIG_STRAIGHT = "big straight"
CHOICE = "choice"


def score(dice, category):
    match category:
        case "yacht":
            if len(set(dice)) == 1:
                return 50
        case "choice":
            return sum(dice)
        case "big straight":
            if set(dice) == {2,3,4,5,6}:
                return 30
        case "little straight":
            if set(dice) == {1,2,3,4,5}:
                return 30
        case "four of a kind":
            dice.sort()
            if len(set(dice[0:4])) == 1 or len(set(dice[1:5])) == 1:
                return 4 * dice[2]
        case "full house":
            dice.sort()
            if ((len(set(dice[0:3])) == 1 and len(set(dice[3:5])) == 1) or (len(set(dice[0:2])) == 1 and len(set(dice[2:5])) == 1)) and dice[1] != dice[3]:
                return 2 * dice[0] + dice[2] + 2 * dice[4]
        case number:
            return number * dice.count(number)
    return 0