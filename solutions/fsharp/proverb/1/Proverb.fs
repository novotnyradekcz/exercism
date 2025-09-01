module Proverb

let recite (input: string list): string list = 
    match input with
    | [] ->
        []
    | [one] ->
        [$"And all for the want of a {one}."]
    | _ ->
        let shiftedInput = List.permute (fun x -> (x + List.length input - 1) % List.length input) input
        let shiftedOutput = List.map2 (fun x y -> $"For want of a {x} the {y} was lost.") input shiftedInput |> List.take (List.length input - 1)
        List.append shiftedOutput [$"And all for the want of a {List.head input}."]