module TisburyTreasureHunt

let getCoordinate (line: string * string): string = snd line

let convertCoordinate (coordinate: string): int * char = int (string coordinate.[0]), coordinate[1]

let compareRecords (azarasData: string * string) (ruisData: string * (int * char) * string) : bool = 
    let _, ruisCoordinate, _ = ruisData
    if convertCoordinate (snd azarasData) = ruisCoordinate then
        true
    else false

let createRecord (azarasData: string * string) (ruisData: string * (int * char) * string) : (string * string * string * string) =
    if compareRecords azarasData ruisData then
        let location, _, quadrant = ruisData
        snd azarasData, location, quadrant, fst azarasData
    else
        "", "", "", ""
