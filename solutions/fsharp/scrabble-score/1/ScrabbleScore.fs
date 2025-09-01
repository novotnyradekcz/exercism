module ScrabbleScore

open System

let score word = 
    let getScore (letter: char) =
        match Char.ToLower(letter) with
        | 'a' | 'e' | 'i' | 'o' | 'u' | 'l' | 'n' | 'r' | 's' | 't' -> 1
        | 'd' | 'g' -> 2
        | 'b' | 'c' | 'm' | 'p' -> 3
        | 'f' | 'h' | 'v' | 'w' | 'y' -> 4
        | 'k' -> 5
        | 'j' | 'x' -> 8
        | 'q' | 'z' -> 10
        | _ -> 0
    word |> Seq.fold (fun s a -> s + getScore a) 0