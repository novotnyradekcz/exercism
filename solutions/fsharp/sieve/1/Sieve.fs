module Sieve

let primes limit = 
    if limit < 2 then
        []
    else
        let mutable numbers = [2..limit]
        for number in numbers do
            numbers <- List.filter (fun x -> (x = number) || (x % number <> 0)) numbers
        numbers