"""A simple function for flattening a list, skipping nulls"""

def flatten(iterable):
    result = []
    def inner_flatten(res, iter):
        for item in iter:
            if isinstance(item, list):
                inner_flatten(res, item)
            elif item is not None:
                res.append(item)
    inner_flatten(result, iterable)
    return result
