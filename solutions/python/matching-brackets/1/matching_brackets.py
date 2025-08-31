"""A simple function for checking if brackets in a string match"""

def is_paired(input_string):
    only_brackets = ""
    for character in input_string:
        if character in "([{}])":
            only_brackets += character
    for open, close in {"(": ")", "[": "]", "{": "}"}.items():
        if input_string.count(open) != input_string.count(close):
            return False
    while "()" in only_brackets or "[]" in only_brackets or "{}" in only_brackets:
        only_brackets = only_brackets.replace("()", "")
        only_brackets = only_brackets.replace("[]", "")
        only_brackets = only_brackets.replace("{}", "")
    if only_brackets != "":
        return False
    return True
