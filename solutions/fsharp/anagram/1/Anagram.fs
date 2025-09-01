module Anagram

let isAnagram (s1:string) (s2:string) =
    s1.ToLower().ToCharArray() |> Array.sort = (s2.ToLower().ToCharArray() |> Array.sort)

let findAnagrams (candidates:string seq) (target:string) =
    candidates
    |> Seq.filter (fun s -> s.ToLower() <> target.ToLower() && isAnagram target s)
    |> Seq.toList