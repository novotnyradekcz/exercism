module LargestSeriesProduct

open System

let notDigit input =
    input |> Seq.forall Char.IsDigit |> not

let largestProduct (input: string) (seriesLength: int) : int option =
    if input.Length < seriesLength || seriesLength < 0 || notDigit input then
        None
    else
        List.init (input.Length - seriesLength + 1) (fun _ -> 1)
        |> List.mapi (fun i x ->
            input[i..i + seriesLength - 1]
            |> Seq.map (fun a -> int a - 48)
            |> Seq.reduce (fun y z -> y * z))
        |> List.max
        |> Some
        