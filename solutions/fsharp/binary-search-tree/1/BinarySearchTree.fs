module BinarySearchTree

type BinaryTree = {
    Data: int
    Left: BinaryTree option
    Right: BinaryTree option
}

let left node = node.Left

let right node = node.Right

let data node = node.Data

let rec private createTree items =
    let h = items |> List.head
    let t = items |> List.tail
    let l, r = t |> List.partition (fun x -> x <= h)
    
    {
        Data = h
        Left = if l = [] then None else Some (createTree l)
        Right = if r = [] then None else Some (createTree r)
    }

let rec private sort node =
        match node with
        | None -> []
        | Some n -> sort (left n) @ [data n] @ sort (right n)

let rec create items =
    match items with
    | [] -> failwith "Cannot create tree from no data."
    | x -> createTree x

let sortedData node = sort (Some node)