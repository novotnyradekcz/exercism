module InterestIsInteresting

let interestRate (balance: decimal): single =
    match balance with
        | b when b < 0.0m -> 3.213f
        | b when b < 1000.0m -> 0.5f
        | b when b < 5000.0m -> 1.621f
        | _ -> 2.475f

let interest (balance: decimal): decimal =
   0.01m * decimal (interestRate balance) * balance

let annualBalanceUpdate(balance: decimal): decimal =
   balance + interest balance

let amountToDonate(balance: decimal) (taxFreePercentage: float): int =
    if balance > 0.0m then
        int (0.02m * decimal (taxFreePercentage) * balance)
    else
        0