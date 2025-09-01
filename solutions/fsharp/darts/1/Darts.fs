module Darts

let score (x: double) (y: double): int =
    let distanceToCenter = sqrt (x ** 2 + y ** 2)
    match distanceToCenter with
        | r when r <= 1 -> 10
        | r when r <= 5 -> 5
        | r when r <= 10 -> 1
        | _ -> 0