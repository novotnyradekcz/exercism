module CollatzConjecture

let steps (number: int): int option = 
    let mutable counter = 0 |> Some
    if number > 0 then
        let mutable n = number
        while n <> 1 do
            n <- if n % 2 = 0 then n / 2 else 3 * n + 1
            counter <- Option.map ((+) 1) counter
        counter
    else
        None