module RobotSimulator

type Direction = North | East | South | West
type Position = int * int
type Robot = 
  { Direction: Direction
    Position: Position }

let create direction position = { Direction = direction; Position = position }

let rec move instructions robot = 
    let mutable direction = robot.Direction
    let mutable position = robot.Position
    for i in instructions do
        match i with
        | 'L' -> 
            match direction with
            | North -> direction <- West
            | East -> direction <- North
            | South -> direction <- East
            | West -> direction <- South
        | 'R' -> 
            match direction with
            | North -> direction <- East
            | East -> direction <- South
            | South -> direction <- West
            | West -> direction <- North
        | _ ->
            match direction with
            | North -> position <- (fst position, snd position + 1)
            | East -> position <- (fst position + 1, snd position)
            | South -> position <- (fst position, snd position - 1)
            | West -> position <- (fst position - 1, snd position)
    create direction position