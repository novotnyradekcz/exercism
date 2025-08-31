def proverb(*things, qualifier):
    if len(things) == 0:
        return []
    [first, *rest] = things
    if qualifier != None:
        last = "And all for the want of a " + qualifier + " " + first + "."
    else:
        last = "And all for the want of a " + first + "."
    verses = []
    for i in range(len(rest)):
        verses.append("For want of a " + first + " the " + rest[i] + " was lost.")
        first = rest[i]
    return verses + [last]