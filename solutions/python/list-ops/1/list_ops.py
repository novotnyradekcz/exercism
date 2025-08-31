def append(list1, list2):
    return list1 + list2


def concat(lists):
    result = []
    for lst in lists:
        result += lst
    return result


def filter(function, list):
    result = []
    for item in list:
        if function(item):
            result += [item]
    return result


def length(list):
    counter = 0
    for item in list:
        counter += 1
    return counter


def map(function, list):
    result = []
    for item in list:
        result += [function(item)]
    return result


def foldl(function, list, initial):
    result = initial
    for item in list:
        result = function(result, item)
    return result


def foldr(function, list, initial):
    result = initial
    for idx in range(len(list)):
        result = function(list[len(list) - idx - 1], result)
    return result


def reverse(list):
    result = []
    for idx in range(len(list)):
        result += [list[len(list) - idx - 1]]
    return result
