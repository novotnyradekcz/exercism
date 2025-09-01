module SecretHandshake

let commands number = 
    let wink = number % 2
    let doubleBlink = number / 2 % 2
    let closeYourEyes = number / 2 / 2 % 2
    let jump = number / 2 / 2 / 2 % 2
    let reverse = number / 2 / 2 / 2 / 2 % 2
    match reverse with
    | 0 -> [wink, "wink"; doubleBlink, "double blink"; closeYourEyes, "close your eyes"; jump, "jump"]
    | 1 -> [jump, "jump"; closeYourEyes, "close your eyes"; doubleBlink, "double blink"; wink, "wink"]
    | _ -> []
    |> List.map (fun (x, y) -> if x = 1 then y else "")
    |> List.filter (fun x -> x <> "")