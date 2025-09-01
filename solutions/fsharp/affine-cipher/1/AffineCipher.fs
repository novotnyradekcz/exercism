module AffineCipher

open System

let mmi a =
    [0..25] |> List.filter (fun x -> (a * x) % 26 = 1) |> List.exactlyOne

let decode (a: int) (b: int) (cipheredText: string) =
    match a with
    | a when a % 2 = 0 || a % 13 = 0 || a % 26 = 0 ->
        invalidArg "Invalid argument" "Invalid argument"
    | _ ->
        cipheredText.ToLower() |> String.filter Char.IsAsciiLetterOrDigit |> String.map (fun c ->
            match c with
            | d when Char.IsAsciiLetterLower d = true -> char ((( mmi a * ((int d - int 'a') - b + 260)) % 26) + int 'a')
            | e -> e
        )

let encode (a: int) (b: int) (plainText: string) = 
    match a with
    | a when a % 2 = 0 || a % 13 = 0 || a % 26 = 0 ->
        invalidArg "Invalid argument" "Invalid argument"
    | _ ->
        plainText.ToLower() |> String.filter Char.IsAsciiLetterOrDigit |> String.map (fun c ->
            match c with
            | d when Char.IsAsciiLetterLower d = true -> char (((a * (int d - int 'a') + b) % 26) + int 'a')
            | e -> e
        ) |> Seq.fold (fun acc c -> if String.length acc % 6 = 5 then acc + $" {c}" else acc + $"{c}") ""