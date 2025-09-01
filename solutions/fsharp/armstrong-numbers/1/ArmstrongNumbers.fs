module ArmstrongNumbers

let isArmstrongNumber (number: int): bool = 
    let digits =
        number.ToString().ToCharArray()
        |> Array.map (System.Char.GetNumericValue >> System.Convert.ToInt32)
    number = Array.fold (fun (acc: int) (x: int) -> acc + int (bigint x ** digits.Length)) 0 digits