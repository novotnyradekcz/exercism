module QueenAttack

let create (position: int * int) = 
    if fst position >= 0 && fst position <= 7 && snd position >= 0 && snd position <= 7 then
        true
    else
        false

let canAttack (queen1: int * int) (queen2: int * int) = 
    match (queen1, queen2) with
    | ((a, b), (c, d)) when a = c -> true
    | ((a, b), (c, d)) when b = d -> true
    | ((a, b), (c, d)) when a - b = c - d -> true
    | ((a, b), (c, d)) when a + b = c + d -> true
    | _ -> false