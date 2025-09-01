module TwelveDays

let recite start stop =
    let days = [
        (1, "first")
        (2, "second")
        (3, "third")
        (4, "fourth")
        (5, "fifth")
        (6, "sixth")
        (7, "seventh")
        (8, "eighth")
        (9, "ninth")
        (10, "tenth")
        (11, "eleventh")
        (12, "twelfth")
    ]
    let gifts = [
        "and a Partridge in a Pear Tree."
        "two Turtle Doves, "
        "three French Hens, "
        "four Calling Birds, "
        "five Gold Rings, "
        "six Geese-a-Laying, "
        "seven Swans-a-Swimming, "
        "eight Maids-a-Milking, "
        "nine Ladies Dancing, "
        "ten Lords-a-Leaping, "
        "eleven Pipers Piping, "
        "twelve Drummers Drumming, "
    ]

    let concatenateStrings one two =
        one + two

    days[start - 1..stop - 1]
    |> List.map (fun day ->
        match snd day with
        | "first" -> "On the first day of Christmas my true love gave to me: a Partridge in a Pear Tree."
        | _ ->
            concatenateStrings
                $"On the {snd day} day of Christmas my true love gave to me: "
                (gifts[..fst day - 1] |> List.rev |> String.concat ""))