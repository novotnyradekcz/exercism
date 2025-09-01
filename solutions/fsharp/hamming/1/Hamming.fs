module Hamming

let distance (strand1: string) (strand2: string): int option = 
    if ((String.length strand1) = (String.length strand2)) then
        Some(List.fold2 (fun s x y -> (if x = y then s else s + 1)) 0 (Seq.toList strand1) (Seq.toList strand2))
    else
        None