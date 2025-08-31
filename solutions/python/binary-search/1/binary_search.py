def find(search_list, value):
    def recursiveFind(search_list, value, idx):
        if len(search_list) == 0:
            raise ValueError("value not in array")
        elif len(search_list) == 1:
            if search_list[0] == value:
                return idx
            else:
                raise ValueError("value not in array")
        else:
            middle = search_list[len(search_list) // 2]
            if value == middle:
                return search_list.index(middle) + idx
            elif value < middle:
                return recursiveFind(search_list[:search_list.index(middle)], value, idx)
            else:
                idx += search_list.index(middle) + 1
                return recursiveFind(search_list[search_list.index(middle) + 1:], value, idx)

    return recursiveFind(search_list, value, 0)
