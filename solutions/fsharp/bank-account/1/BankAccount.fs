module BankAccount

type BankAccount = {
    mutable Balance: decimal option
}

let mkBankAccount () = {
    Balance = None
}

let openAccount account =
    account.Balance <- Some 0.0m
    account

let closeAccount account =
    account.Balance <- None
    account

let getBalance account = account.Balance

let updateBalance change account =
    lock account (fun () ->
        match account.Balance with
        | None -> ()
        | Some balance -> account.Balance <- Some (balance + change))
    account
