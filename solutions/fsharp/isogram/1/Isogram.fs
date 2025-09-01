module Isogram

let isIsogram (str: string) =
    let chars = String.filter (fun x -> x <> ' ' && x <> '-') (str.ToLower())
    let distinctChars = Set.ofSeq chars
    chars.Length = distinctChars.Count