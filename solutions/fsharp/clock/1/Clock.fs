module Clock

let create hours minutes = ((60 * hours + minutes) % 1440 + 1440) % 1440

let add minutes clock = ((clock + minutes) % 1440 + 1440) % 1440

let subtract minutes clock = ((clock - minutes) % 1440 + 1440) % 1440

let display clock = 
    if (clock / 60) > 9 && (clock % 60) > 9 then
        string (clock / 60) + ":" + string (clock % 60)
    elif (clock / 60) < 10 && (clock % 60) > 9 then
        "0" + string (clock / 60) + ":" + string (clock % 60)
    elif (clock / 60) > 9 && (clock % 60) < 10 then
        string (clock / 60) + ":0" + string (clock % 60)
    else
        "0" + string (clock / 60) + ":0" + string (clock % 60)