module BinarySearch

let find (input: int[]) (value: int) = 
    let rec search low high =
        if low > high then
            None
        else
            let mid = (low + high) / 2
            if input.[mid] = value then
                Some mid
            elif input.[mid] > value then
                search low (mid - 1)
            else
                search (mid + 1) high
    search 0 (Array.length input - 1)