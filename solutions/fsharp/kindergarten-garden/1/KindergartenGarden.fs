module KindergartenGarden

// TODO: define the Plant type
type Plant =
    | Grass
    | Clover
    | Radishes
    | Violets

let which x =
    match x with
        | 'C' -> Clover
        | 'G' -> Grass
        | 'V' -> Violets
        | _ -> Radishes

let plants (diagram: string) (student: string) =
    match student with
        | "Alice" -> diagram.[0..1] + diagram.[(diagram.Length / 2 + 1)..(diagram.Length / 2 + 2)]
        | "Bob" -> diagram.[2..3] + diagram.[(diagram.Length / 2 + 3)..(diagram.Length / 2 + 4)]
        | "Charlie" -> diagram.[4..5] + diagram.[(diagram.Length / 2 + 5)..(diagram.Length / 2 + 6)]
        | "David" -> diagram.[6..7] + diagram.[(diagram.Length / 2 + 7)..(diagram.Length / 2 + 8)]
        | "Eve" -> diagram.[8..9] + diagram.[(diagram.Length / 2 + 9)..(diagram.Length / 2 + 10)]
        | "Fred" -> diagram.[10..11] + diagram.[(diagram.Length / 2 + 11)..(diagram.Length / 2 + 12)]
        | "Ginny" -> diagram.[12..13] + diagram.[(diagram.Length / 2 + 13)..(diagram.Length / 2 + 14)]
        | "Harriet" -> diagram.[14..15] + diagram.[(diagram.Length / 2 + 15)..(diagram.Length / 2 + 16)]
        | "Ileana" -> diagram.[16..17] + diagram.[(diagram.Length / 2 + 17)..(diagram.Length / 2 + 18)]
        | "Joseph" -> diagram.[18..19] + diagram.[(diagram.Length / 2 + 19)..(diagram.Length / 2 + 20)]
        | "Kincaid" -> diagram.[20..21] + diagram.[(diagram.Length / 2 + 21)..(diagram.Length / 2 + 22)]
        | "Larry" -> diagram.[22..23] + diagram.[(diagram.Length / 2 + 23)..(diagram.Length / 2 + 24)]
        | _ -> ""
    |> Seq.toList |> List.map which