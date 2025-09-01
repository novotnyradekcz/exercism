module Pangram

let isPangram (input: string): bool = "abcdefghijklmnopqrstuvwxyz" |> String.forall (fun x -> input.ToLower().Contains(x))