module Bob

open System.Text.RegularExpressions

let isUppercase (input:string):bool =
     Regex.Match(input, "[A-Z]").Success
     && not(Regex.Match(input, "[a-z]").Success)

let response (input: string): string =
    let trimmed = input.Trim()
    if trimmed = "" then
            "Fine. Be that way!"
    elif isUppercase trimmed then
        if (Seq.toList trimmed |> List.last) = '?' then
            "Calm down, I know what I'm doing!"
        else
            "Whoa, chill out!"
    else
        if (Seq.toList trimmed |> List.last) = '?' then
            "Sure."
        else
            "Whatever."