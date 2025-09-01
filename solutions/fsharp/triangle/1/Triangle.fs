module Triangle

let positiveSides triangle = 
    let checkPositive x = if x > 0.0 then true else false
    List.map checkPositive triangle |> List.fold (fun a s -> a && s) true

let isTriangle (triangle: List<float>) =
    if triangle.[0] + triangle.[1] > triangle.[2] && triangle.[1] + triangle.[2] > triangle.[0] && triangle.[2] + triangle[0] > triangle.[1] then
        true
    else
        false

let equilateral triangle =
    if positiveSides triangle && isTriangle triangle then
        if triangle.[0] = triangle.[1] && triangle.[1] = triangle.[2] && triangle.[2] = triangle[0] then
            true
        else
            false
    else
        false

let isosceles triangle = 
    if positiveSides triangle && isTriangle triangle then
        if triangle.[0] = triangle.[1] || triangle.[1] = triangle.[2] || triangle.[2] = triangle[0] then
            true
        else
            false
    else
        false

let scalene triangle = 
    if positiveSides triangle && isTriangle triangle then
        if triangle.[0] <> triangle.[1] && triangle.[1] <> triangle.[2] && triangle.[2] <> triangle[0] then
            true
        else
            false
    else
        false
