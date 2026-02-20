module RnaTranscription exposing (toRNA)


toRNA : String -> Result String String
toRNA dna =
    let
        transcribe : Char -> Maybe Char
        transcribe nucleotide =
            case nucleotide of
                'G' -> Just 'C'
                'C' -> Just 'G'
                'T' -> Just 'A'
                'A' -> Just 'U'
                _   -> Nothing

        transcribeAll : String -> Maybe String
        transcribeAll input =
            input
                |> String.toList
                |> List.map transcribe
                |> List.foldr
                    (\maybeChar acc ->
                        case (maybeChar, acc) of
                            (Just c, Just rest) -> Just (c :: rest)
                            _ -> Nothing
                    )
                    (Just [])
                |> Maybe.map String.fromList
    in
    case transcribeAll dna of
        Just rna -> Ok rna
        Nothing -> Err "Invalid DNA sequence"
