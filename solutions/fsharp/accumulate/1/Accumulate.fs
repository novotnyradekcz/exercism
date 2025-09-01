module Accumulate

let accumulate (func: 'a -> 'b) (input: 'a list): 'b list = 
    let rec accum func acc = function
            | [] -> acc
            | h :: t -> accum func (func h :: acc) t
    accum func [] input |> List.rev
