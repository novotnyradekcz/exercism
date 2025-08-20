#include "robot_simulator.h"

robot_status_t robot_create(robot_direction_t direction, int x, int y)
{
    robot_status_t    robot =
    {
        direction,
        {x, y}
    };
    return robot;
}

void robot_move(robot_status_t *robot, const char *commands)
{
    for (size_t i = 0; i < strlen(commands); i++)
    {
        switch (commands[i])
        {
            case 'A':
                switch (robot->direction)
                {
                    case 0:
                        robot->position.y++;
                        break;
                    case 1:
                        robot->position.x++;
                        break;
                    case 2:
                        robot->position.y--;
                        break;
                    case 3:
                        robot->position.x--;
                        break;
                    default:
                        break;
                }
                break;
            case 'R':
                if (robot->direction == 3)
                    robot->direction = 0;
                else
                    robot->direction++;
                break;
            case 'L':
                if (robot->direction == 0)
                    robot->direction = 3;
                else
                    robot->direction--;
                break;
        }
    }
}