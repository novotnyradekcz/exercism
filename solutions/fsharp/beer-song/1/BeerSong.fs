module BeerSong

let recite (startBottles: int) (takeDown: int) = 
    let mutable result = []
    for bottles in startBottles .. -1 .. (startBottles - takeDown + 1) do
        match bottles with
        | 0 -> result <- List.append result ["No more bottles of beer on the wall, no more bottles of beer.";
            "Go to the store and buy some more, 99 bottles of beer on the wall."]
        | 1 -> result <- List.append result ["1 bottle of beer on the wall, 1 bottle of beer.";
            "Take it down and pass it around, no more bottles of beer on the wall."]
        | 2 -> result <- List.append result ["2 bottles of beer on the wall, 2 bottles of beer.";
            "Take one down and pass it around, 1 bottle of beer on the wall."]
        | _ -> result <- List.append result [string bottles + " bottles of beer on the wall, " + string bottles + " bottles of beer.";
            "Take one down and pass it around, " + string (bottles - 1) + " bottles of beer on the wall."]
        if  not (bottles = startBottles - takeDown + 1) then
            result <- List.append result [""]
    result
        