module AllYourBase

let rebase digits inputBase outputBase = 
    if (digits |> List.exists (fun x -> x < 0)) || inputBase < 2 || outputBase < 2 then
        None
    elif digits = [] then
        Some [0]
    elif digits |> List.exists (fun x -> x >= inputBase) then
        None
    else
        let decimal =
            digits
            |> List.mapi (fun i x ->
                (float x) * (float inputBase) ** (float (digits.Length - i - 1)))
            |> List.sum

        let rec toBase number result =
            if number = 0 then
                Some result
            else
                toBase (number / outputBase) ((number % outputBase)::result)

        if decimal = 0 then
            Some [0]
        else
            toBase (decimal |> int) []