module CircularBuffer

type CircularBuffer = {
    Size: int
    Values: int list
}

let mkCircularBuffer size = { Size = size; Values = [] }

let clear (buffer: CircularBuffer) = { buffer with Values = [] }

let write value (buffer: CircularBuffer) =
    if buffer.Size = buffer.Values.Length then
        failwith "Buffer full."
    { buffer with Values = buffer.Values @ [ value ] }
        
let forceWrite value (buffer: CircularBuffer) =
    if buffer.Size <> buffer.Values.Length then
        write value buffer
    else
        {    
            buffer with
                Values = buffer.Values[1..] @ [ value ]
        }

let read (buffer: CircularBuffer) =
    match buffer.Values with
    | [] -> failwith "You need to implement this function."
    | head::tail -> (head, { buffer with Values = tail })