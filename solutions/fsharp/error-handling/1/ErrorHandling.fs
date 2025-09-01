module ErrorHandling

open System

let handleErrorByThrowingException() = failwith "Exception"

let handleErrorByReturningOption (input: string) : int option = 
    try
        Some (int input)
    with
        | _ -> None

let handleErrorByReturningResult (input: string) : Result<int, string> = 
    try
        Ok (int input)
    with
        | _ -> Error "Could not convert input to integer"

let bind switchFunction twoTrackInput = 
    match twoTrackInput with
    | Ok x -> switchFunction x
    | Error e -> Error e

let cleanupDisposablesWhenThrowingException (resource: IDisposable) = 
    use innerResource = resource
    try
        failwith "Exception"
    with ex ->
        innerResource.Dispose()
        raise ex