module Etl

let transform (scoresWithLetters: Map<int, char list>): Map<char, int> = 
    scoresWithLetters |> Map.toSeq
    |> Seq.collect (fun (score, letters) -> letters |> Seq.map (fun letter -> System.Char.ToLower(letter), score))
    |> Map.ofSeq