module Yacht

type Category = 
    | Ones
    | Twos
    | Threes
    | Fours
    | Fives
    | Sixes
    | FullHouse
    | FourOfAKind
    | LittleStraight
    | BigStraight
    | Choice
    | Yacht

type Die =
    | One = 1
    | Two = 2
    | Three = 3
    | Four = 4
    | Five = 5
    | Six = 6

let score category dice = 
    match category with
        | Category.Ones -> dice |> List.filter (fun x -> x = Die.One) |> List.fold (fun s c -> s + 1) 0
        | Category.Twos -> dice |> List.filter (fun x -> x = Die.Two) |> List.fold (fun s c -> s + 2) 0
        | Category.Threes -> dice |> List.filter (fun x -> x = Die.Three) |> List.fold (fun s c -> s + 3) 0
        | Category.Fours -> dice |> List.filter (fun x -> x = Die.Four) |> List.fold (fun s c -> s + 4) 0
        | Category.Fives -> dice |> List.filter (fun x -> x = Die.Five) |> List.fold (fun s c -> s + 5) 0
        | Category.Sixes -> dice |> List.filter (fun x -> x = Die.Six) |> List.fold (fun s c -> s + 6) 0
        | Category.FullHouse ->
            let groups = List.groupBy (fun x -> x) dice
            match groups with
                | (v1, [c1; c2; c3]) :: (v2, [c4; c5]) :: rest -> List.fold (fun s c -> s + int c) 0 dice
                | (v1, [c1; c2]) :: (v2, [c3; c4; c5]) :: rest -> List.fold (fun s c -> s + int c) 0 dice
                | _ -> 0
        | Category.FourOfAKind -> 
            let sum = List.filter (fun x -> x = Die.One) dice |> List.length
            if sum >= 4 then
                4
            else
                let sum = List.filter (fun x -> x = Die.Two) dice |> List.length
                if sum >= 4 then
                    8
                else
                    let sum = List.filter (fun x -> x = Die.Three) dice |> List.length
                    if sum >= 4 then
                        12
                    else
                        let sum = List.filter (fun x -> x = Die.Four) dice |> List.length
                        if sum >= 4 then
                            16
                        else
                            let sum = List.filter (fun x -> x = Die.Five) dice |> List.length
                            if sum >= 4 then
                                20
                            else
                                let sum = List.filter (fun x -> x = Die.Six) dice |> List.length
                                if sum >= 4 then
                                    24
                                else
                                    0
        | Category.LittleStraight ->
            if (List.contains Die.One dice) && (List.contains Die.Two dice) && (List.contains Die.Three dice) && (List.contains Die.Four dice) && (List.contains Die.Five dice) then
                30
            else
                0
        | Category.BigStraight ->
            if (List.contains Die.Six dice) && (List.contains Die.Two dice) && (List.contains Die.Three dice) && (List.contains Die.Four dice) && (List.contains Die.Five dice) then
                30
            else
                0
        | Category.Choice -> dice |> List.fold (fun s c -> s + int c) 0
        | Category.Yacht ->
            if List.forall (fun x -> x = Die.One) dice || List.forall (fun x -> x = Die.Two) dice || List.forall (fun x -> x = Die.Three) dice || List.forall (fun x -> x = Die.Four) dice || List.forall (fun x -> x = Die.Five) dice || List.forall (fun x -> x = Die.Six) dice then
                50
            else
                0