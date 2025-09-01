module Acronym

let abbreviate (phrase: string): string =
    phrase.Split([|' '; '\n'; '\t'; '\v'; '\f'; '\r'; '-'; '_'|], System.StringSplitOptions.RemoveEmptyEntries)
    |> Array.map (fun (x:string) -> x.[0])
    |> fun x -> (new string(x)).ToUpper()