"""A simple function for decoding resistor color bands"""

def label(colors):
    color_list = ["black", 
                 "brown", 
                 "red", 
                 "orange", 
                 "yellow", 
                 "green", 
                 "blue", 
                 "violet", 
                 "grey", 
                 "white"]
    ohms = (10 * color_list.index(colors[0]) \
        + color_list.index(colors[1])) \
        * 10 ** color_list.index(colors[2])
    if ohms >= 1000000000:
        return str(int(ohms / 1000000000)) + " gigaohms"
    if ohms >= 1000000:
        return str(int(ohms / 1000000)) + " megaohms"
    if ohms >= 1000:
        return str(int(ohms / 1000)) + " kiloohms"
    return str(ohms) + " ohms"
