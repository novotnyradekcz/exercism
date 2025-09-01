module CarsAssemble

let successRate (speed: int): float =
    if speed = 0 then
        0.0
    else if speed >= 1 && speed <= 4 then
        1.0
    else if speed >= 5 && speed <= 8 then
        0.9
    else if speed = 9 then
        0.8
    else
        0.77

let productionRatePerHour (speed: int): float =
    float (float(221) * float(speed) * (successRate speed))

let workingItemsPerMinute (speed: int): int =
    int ((productionRatePerHour speed) / float(60))
