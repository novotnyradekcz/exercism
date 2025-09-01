module NucleotideCount

let nucleotideCounts (strand: string): Option<Map<char, int>> =  
    if String.forall (fun c -> c = 'A' || c = 'C' || c = 'G' || c = 'T') strand then
        let mutable counts = [('A', 0); ('C', 0); ('G', 0); ('T', 0)] |> Map.ofList
        strand |> Seq.countBy id |> Seq.iter (fun (c, i) -> counts <- Map.add c i counts)
        Some counts
    else
        None