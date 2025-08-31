def egg_count(display_value):
    egg_counter = 0
    while display_value > 0:
        egg_counter += (display_value % 2)
        display_value //= 2
    return egg_counter
