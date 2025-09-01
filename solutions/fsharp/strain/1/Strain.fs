module Seq

let keep pred xs = 
    let mutable result = []
    for x in xs do
        if pred x then
            result <- x :: result
    List.rev result

let discard pred xs = 
    let mutable result = []
    for x in xs do
        if not (pred x) then
            result <- x :: result
    List.rev result