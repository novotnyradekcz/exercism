module ReverseString

let rec reverse (input: string): string =
    match input with
        | "" -> ""
        | _ -> input.[input.Length - 1].ToString() + reverse (input.[0..input.Length-2])
