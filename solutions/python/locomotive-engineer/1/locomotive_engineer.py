"""Functions which helps the locomotive engineer to keep track of the train."""


def get_list_of_wagons(*args):
    """Return a list of wagons.

    :param: arbitrary number of wagons.
    :return: list - list of wagons.
    """
    [*wagons] = args
    return wagons


def fix_list_of_wagons(each_wagons_id, missing_wagons):
    """Fix the list of wagons.

    :parm each_wagons_id: list - the list of wagons.
    :parm missing_wagons: list - the list of missing wagons.
    :return: list - list of wagons.
    """
    [wagon_1, wagon_2, locomotive, *rest] = each_wagons_id
    return [locomotive] + missing_wagons + rest + [wagon_1, wagon_2]


def add_missing_stops(route, **missing_stops):
    """Add missing stops to route dict.

    :param route: dict - the dict of routing information.
    :param: arbitrary number of stops.
    :return: dict - updated route dictionary.
    """
    stops = []
    for stop in missing_stops.values():
        stops.append(stop)
    route["stops"] = stops
    return route


def extend_route_information(route, more_route_information):
    """Extend route information with more_route_information.

    :param route: dict - the route information.
    :param more_route_information: dict -  extra route information.
    :return: dict - extended route information.
    """
    for key, value in more_route_information.items():
        route[key] = value
    return route


def fix_wagon_depot(wagons_rows):
    """Fix the list of rows of wagons.

    :param wagons_rows: list[list[tuple]] - the list of rows of wagons.
    :return: list[list[tuple]] - list of rows of wagons.
    """
    one = []
    two = []
    three = []
    for row in wagons_rows:
        one.append(row[0])
        two.append(row[1])
        three.append(row[2])
    return [one, two, three]
