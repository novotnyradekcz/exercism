"""A function for evaluating simple math word problems"""

def answer(question):
    if question == "What is?":
        raise ValueError("syntax error")
    if not question.startswith("What is "):
        raise ValueError("unknown operation")
    problem = question[7:-1].split()
    idx = 0
    buffer = 0
    if not problem[idx].isnumeric() and not (problem[idx][0] == "-" and problem[idx][1:].isnumeric()):
        raise ValueError("syntax error")
    buffer = int(problem[idx])
    idx += 1
    if idx == len(problem):
        return buffer
    while idx < len(problem):
        if problem[idx].isnumeric():
            raise ValueError("syntax error")
        if problem[idx] not in ["plus", "minus", "multiplied", "divided"]:
            raise ValueError("unknown operation")
        match problem[idx]:
            case "plus":
                idx += 1
                if idx == len(problem) or (not problem[idx].isnumeric() and not (problem[idx][0] == "-" and problem[idx][1:].isnumeric())):
                    raise ValueError("syntax error")
                buffer += int(problem[idx])
            case "minus":
                idx += 1
                if not problem[idx].isnumeric() and not (problem[idx][0] == "-" and problem[idx][1:].isnumeric()):
                    raise ValueError("syntax error")
                buffer -= int(problem[idx])
            case "multiplied":
                idx += 1
                if problem[idx] != "by":
                    raise ValueError("syntax error")
                idx += 1
                if not problem[idx].isnumeric() and not (problem[idx][0] == "-" and problem[idx][1:].isnumeric()):
                    raise ValueError("syntax error")
                buffer *= int(problem[idx])
            case "divided":
                idx += 1
                if problem[idx] != "by":
                    raise ValueError("syntax error")
                idx += 1
                if not problem[idx].isnumeric() and not (problem[idx][0] == "-" and problem[idx][1:].isnumeric()):
                    raise ValueError("syntax error")
                buffer /= int(problem[idx])
        idx += 1
    return buffer
