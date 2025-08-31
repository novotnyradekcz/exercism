"""A simple fuction for decoding resistor band colours"""

def value(colors):
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
    return 10 * color_list.index(colors[0]) + color_list.index(colors[1])