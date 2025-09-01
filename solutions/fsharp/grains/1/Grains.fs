module Grains

let square (n: int): Result<uint64,string> = 
    match n with
    | n when n > 64 -> Error "square must be between 1 and 64"
    | n when n < 1 -> Error "square must be between 1 and 64"
    | _ -> Ok (uint64 ((bigint 2) ** (n - 1)))
let total: Result<uint64,string> = Ok (uint64 (Seq.sumBy (fun x -> (bigint 2) ** (x - 1)) [1 .. 64]))