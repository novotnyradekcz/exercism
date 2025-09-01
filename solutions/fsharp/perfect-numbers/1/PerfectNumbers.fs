module PerfectNumbers

type Classification = Perfect | Abundant | Deficient 

let classify n : Classification option =
    if n < 1 then
        None
    elif n = 1 then
        Some Classification.Deficient
    else
        let mutable factors = []
        for i in [1..int(sqrt(float n))] do
            if n % i = 0 then
                factors <- List.append factors [i]
                if n / i <> i && i <> 1 then
                    factors <- List.append factors [n / i]
        let aliquotSum = List.sum factors
        if aliquotSum = n then
            Some Classification.Perfect
        elif aliquotSum > n then
            Some Classification.Abundant
        else
            Some Classification.Deficient
