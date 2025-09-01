module Raindrops

let convert (number: int): string = 
    let mutable result = ""
    if (number % 3 = 0) then
        result <- result + "Pling"
    if (number % 5 = 0) then
        result <- result + "Plang"
    if (number % 7 = 0) then
        result <- result + "Plong"
    if (result = "") then
        result <- string number
    result