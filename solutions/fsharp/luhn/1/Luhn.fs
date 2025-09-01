module Luhn

open System

let valid (number: string) =
    let cleaned = number.Replace(" ", "")
    if cleaned.Length > 1 && cleaned |> String.forall Char.IsDigit then
        let sum =
            cleaned
            |> Seq.map (string >> int)
            |> Seq.rev
            |> Seq.mapi (fun i d -> if i % 2 = 1 then d * 2 else d)
            |> Seq.map (fun d -> if d > 9 then d - 9 else d)
            |> Seq.sum
        sum % 10 = 0
    else
        false
