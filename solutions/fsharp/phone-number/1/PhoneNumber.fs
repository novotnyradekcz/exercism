module PhoneNumber

open System
open System.Text.RegularExpressions

let clean input =
    let noLetters (number: string) =
        if number |> Seq.exists Char.IsLetter then
            Error "letters not permitted"
        else
            Ok number

    let noPunctuation (number: string) =
        if (number |> Seq.contains ';') || (number |> Seq.contains ':') || (number |> Seq.contains '!') || (number |> Seq.contains '@') then
            Error "punctuations not permitted"
        else
            Ok number

    let stripped (number: string) =
        number
        |> Seq.filter Char.IsDigit
        |> Seq.map string
        |> String.concat ""

    let noPrefix (number: string) =
        match number.Length with
        | 10 -> Ok number
        | 11 when number[0] = '1' -> Ok number[1..]
        | 11 -> Error "11 digits must start with 1"
        | more when more > 11 -> Error "more than 11 digits"
        | _ -> Error "incorrect number of digits"

    let areaCode (number: string) =
        match number[0] with
        | '0' -> Error "area code cannot start with zero"
        | '1'-> Error "area code cannot start with one"
        | _ -> Ok number

    let exchangeCode (number: string) =
        match number[3] with
        | '0' -> Error "exchange code cannot start with zero"
        | '1' -> Error "exchange code cannot start with one"
        | _ -> Ok number
    
    input
    |> noLetters
    |> Result.bind noPunctuation
    |> Result.map stripped
    |> Result.bind noPrefix
    |> Result.bind areaCode
    |> Result.bind exchangeCode
    |> Result.map uint64