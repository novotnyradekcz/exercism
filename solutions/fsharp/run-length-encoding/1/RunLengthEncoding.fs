module RunLengthEncoding

open System

let encode (input: string) =
    let inputList = input |> Seq.toList
    let rec recursiveEncode inputList =
        let accum = 
            match inputList with
            | [] -> ""
            | [one] -> one.ToString()
            | head :: tail -> tail |> List.takeWhile (fun x -> x = head) |> List.length |> (+) 1 |> string
        let acc =
            if accum = "1" then
                ""
            else
                accum
        let outputList =
            match inputList with
            | [] -> []
            | [one] -> []
            | head :: tail -> inputList |> List.skipWhile (fun x -> x = head)
        match inputList with
            | [] -> acc
            | [one] -> acc
            | head :: tail -> acc + string head + recursiveEncode outputList
    recursiveEncode inputList

let decode (input: string) =
    let inputList = input |> Seq.toList
    let rec listToInt result (charList: char list) =
        match charList with
            | [] -> result
            | [one] -> listToInt (int (10.0 ** float (List.length charList - 1)) * (int one - int '0') + result) []
            | head :: tail -> listToInt (int (10.0 ** float (List.length charList - 1)) * (int head - int '0') + result) tail
    let rec recursiveDecode inputList =
        match inputList with
        | [] -> ""
        | [one] -> one.ToString()
        | head :: tail when not (Char.IsAsciiDigit head) -> head.ToString() + recursiveDecode tail
        | _ ->
            let count = List.takeWhile (fun c -> Char.IsAsciiDigit c) inputList |> listToInt 0
            let character = List.find (fun c -> not (Char.IsAsciiDigit c)) inputList |> string
            let intermediateList = List.skipWhile (fun c -> Char.IsAsciiDigit c) inputList
            let newList =
                match intermediateList with
                | head :: tail -> tail
                | [] -> []
            String.init count (fun _ -> character) + recursiveDecode newList
    recursiveDecode inputList