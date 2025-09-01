module HighScores

let scores (values: int list): int list = values

let latest (values: int list): int = 
    let reversed = List.rev values
    match reversed with
    | [] -> 0
    | [a] -> a
    | head::tail -> head

let personalBest (values: int list): int = List.max values

let personalTopThree (values: int list): int list = 
    let sorted = List.sortDescending values
    match sorted with
    | [] -> []
    | [a] -> [a]
    | [a; b] -> [a; b]
    | [a; b; c] -> [a; b; c]
    | a::b::c::tail -> [a; b; c]