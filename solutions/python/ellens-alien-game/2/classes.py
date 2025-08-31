"""Solution to Ellen's Alien Game exercise."""


class Alien:
    """Create an Alien object with location x_coordinate and y_coordinate.

    Attributes
    ----------
    (class)total_aliens_created: int
    x_coordinate: int - Position on the x-axis.
    y_coordinate: int - Position on the y-axis.
    health: int - Amount of health points.

    Methods
    -------
    hit(): Decrement Alien health by one point.
    is_alive(): Return a boolean for if Alien is alive (if health is > 0).
    teleport(new_x_coordinate, new_y_coordinate): Move Alien object to new coordinates.
    collision_detection(other): Implementation TBD.
    """

    total_aliens_created = 0

    def __init__(self, *coordinates):
        self.x_coordinate = coordinates[0]
        self.y_coordinate = coordinates[1]
        self.health = 3
        Alien.total_aliens_created += 1

    def hit(self):
        self.health -= 1

    def is_alive(self):
        return self.health > 0

    def teleport(self, *coordinates):
        self.x_coordinate = coordinates[0]
        self.y_coordinate = coordinates[1]

    def collision_detection(self, other_object):
        pass


def new_aliens_collection(coordinates):
    aliens = []
    for coordinate in coordinates:
        aliens.append(Alien(coordinate[0], coordinate[1]))
    return aliens