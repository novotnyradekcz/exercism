module RotationalCipher

open System

let rotate shiftKey text =
    text
    |> Seq.map (fun a ->
        match a with
        | c when Char.IsAsciiLetterLower c -> char ((((int c - int 'a') + shiftKey) % 26) + int 'a')
        | C when Char.IsAsciiLetterUpper C -> char ((((int C - int 'A') + shiftKey) % 26) + int 'A')
        | _ -> a)
    |> String.Concat