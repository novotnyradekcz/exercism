module SqueakyClean

open System

let transform (c: char) : string =
    match c with
    | '-' -> "_"
    | ' ' -> ""
    | upper when Char.IsUpper(upper) -> $"-{Char.ToLower(upper)}"
    | digit when Char.IsDigit(digit) -> ""
    | lowerGreek when  Char.IsBetween(lowerGreek, 'α', 'ω') -> "?"
    | _ -> c.ToString()
    
let clean (identifier: string): string =
    identifier
    |> Seq.map transform
    |> String.concat ""
