module OcrNumbers

let convert input =
    if (input |> List.length) % 4 <> 0 then
        None
    else
        let rowLength =
            input
            |> List.tryFind (fun row ->
                (row |> String.length) % 3 <> 0)
        match rowLength with
        | Some _ -> None
        | None ->
            let convertOne number =
                match number with
                | [" _ "; "| |"; "|_|"; "   "] -> "0"
                | ["   "; "  |"; "  |"; "   "] -> "1"
                | [" _ "; " _|"; "|_ "; "   "] -> "2"
                | [" _ "; " _|"; " _|"; "   "] -> "3"
                | ["   "; "|_|"; "  |"; "   "] -> "4"
                | [" _ "; "|_ "; " _|"; "   "] -> "5"
                | [" _ "; "|_ "; "|_|"; "   "] -> "6"
                | [" _ "; "  |"; "  |"; "   "] -> "7"
                | [" _ "; "|_|"; "|_|"; "   "] -> "8"
                | [" _ "; "|_|"; " _|"; "   "] -> "9"
                | _ -> "?"
            let rec convertAll output (currentRow: string list) (remainingRows: string list) =
                match currentRow with
                | ["" ;"" ;"" ;"" ] ->
                    match remainingRows with
                    | [] -> output
                    | _ ->
                        convertAll
                            (output + ",")
                            (remainingRows |> List.take 4)
                            (remainingRows |> List.skip 4)
                | _ -> 
                    let currentNumber =
                        currentRow
                        |> List.map (fun row -> row[..2])
                        |> convertOne
                    convertAll
                        (output + currentNumber)
                        (currentRow |> List.map (fun row -> row[3..]))
                        (remainingRows)

            convertAll 
                ""
                (input |> List.take 4)
                (input |> List.skip 4)
            |> Some
            
