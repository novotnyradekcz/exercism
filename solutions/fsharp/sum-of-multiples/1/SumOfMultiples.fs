module SumOfMultiples

let sum (numbers: int list) (upperBound: int): int = 
    List.collect (fun num -> 
        match num with
        | 0 -> [0]
        | x -> [x .. x .. upperBound - 1]) numbers
    |> List.distinct |> List.sum