module Meetup

open System

type Week = First | Second | Third | Fourth | Last | Teenth

type DayOfWeek = 
    | Sunday = 0    
    | Monday = 1
    | Tuesday = 2
    | Wednesday = 3
    | Thursday = 4
    | Friday = 5
    | Saturday = 6


let meetup year month week (dayOfWeek: DayOfWeek): DateTime =
    let days =    
        match week with
        | First -> [1..7]
        | Second -> [8..14]
        | Third -> [15..21]
        | Fourth -> [22..28]
        | Last ->
            match month with
            | 2 ->
                match year % 4 with
                | 0 -> [23..29]
                | _ -> [22..28]
            | 4 | 6 | 9 | 11 -> [24..30]
            | _ -> [25..31]
        | Teenth -> [13..19]
    let day = 
        days
        |> List.filter (fun day -> DateTime(year, month, day).DayOfWeek |> int = int dayOfWeek)
        |> List.exactlyOne
    
    DateTime(year, month, day)