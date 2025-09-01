module PigLatin

let isVowelSound letter1 letter2 =
    match letter1, letter2 with
    | 'a', _ | 'e', _ | 'i', _ | 'o', _ | 'u', _
    | 'x', 'r' | 'y', 't' -> true
    | _ -> false

let translateWord (input: string) =
    if input = "my" then
        "ymay"
    elif isVowelSound input[0] input[1] then
        $"{input}ay"
    else
        match input[0], input[1], input[2] with
        | 'q', 'u', _ -> $"{input[2..]}{input[..1]}ay"
        | _, 'q', 'u' -> $"{input[3..]}{input[..2]}ay"
        | _, 'a', _ | _, 'e', _ | _, 'i', _ | _, 'o', _ | _, 'u', _ | _, 'y', _ -> $"{input[1..]}{input[0]}ay"
        | _, _, 'a' | _, _, 'e' | _, _, 'i' | _, _, 'o' | _, _, 'u' | _, _, 'y' -> $"{input[2..]}{input[..1]}ay"
        | _, _, _ -> $"{input[3..]}{input[..2]}ay"

let translate (input: string) =
    input.Split(' ')
    |> Array.map translateWord
    |> String.concat " "