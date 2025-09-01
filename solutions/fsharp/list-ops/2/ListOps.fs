module ListOps

let reverse list =
    let rec innerReverse reversed original =
        match original with
        | [] -> reversed
        | head :: tail -> innerReverse (head :: reversed) (tail)

    innerReverse [] list

let rec foldl folder state list =
    match list with
    | [] -> state
    | head :: tail -> foldl folder (folder state head) tail

let rec foldr folder state list =
    match (list |> reverse) with
    | [] -> state
    | head :: tail -> foldr folder (folder state head) (tail |> reverse)

let length list =
    let rec innerLength len list =
        match list with
        | [] -> len
        | head :: tail -> innerLength (len + 1) tail

    innerLength 0 list

let map f list =
    let rec innerMap mapped input =
        match input with
        | [] -> mapped |> reverse
        | head :: tail -> innerMap (f head :: mapped) tail

    innerMap [] list

let filter f list =
    let rec innerFilter filtered input =
        match input with
        | [] -> filtered |> reverse
        | head :: tail ->
            innerFilter
                (if f head then head :: filtered else filtered)
                tail

    innerFilter [] list

let append xs ys =
    let rec innerAppend list1 list2 =
        match list2 with
        | [] -> list1 |> reverse
        | head :: tail -> innerAppend (head :: list1) tail

    innerAppend (xs |> reverse) ys

let concat xs =
    let rec innerConcat concatenated original =
        match original with
        | [] -> concatenated
        | head :: tail -> innerConcat (append concatenated head) tail

    innerConcat [] xs
