module ProteinTranslation

let proteins rna = 
    Seq.toList rna
    |> List.chunkBySize 3
    |> List.map (List.toArray >> System.String)
    |> List.map (fun x -> 
        match x with
        | "AUG" -> "Methionine"
        | "UUU" | "UUC" -> "Phenylalanine"
        | "UUA" | "UUG" -> "Leucine"
        | "UCU" | "UCC" | "UCA" | "UCG" -> "Serine"
        | "UAU" | "UAC" -> "Tyrosine"
        | "UGU" | "UGC" -> "Cysteine"
        | "UGG" -> "Tryptophan"
        | _ -> "stop")
    |> List.takeWhile (fun x -> not (x = "stop"))