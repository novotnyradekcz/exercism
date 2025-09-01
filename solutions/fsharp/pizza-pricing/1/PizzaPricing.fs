module PizzaPricing

type Pizza =
    | Margherita
    | Caprese
    | Formaggio
    | ExtraSauce of Pizza
    | ExtraToppings of Pizza

let rec pizzaPrice (pizza: Pizza): int = 
    match pizza with
        | Margherita -> 7
        | Caprese -> 9
        | Formaggio -> 10
        | ExtraSauce pizza -> 1 + pizzaPrice pizza
        | ExtraToppings pizza -> 2 + pizzaPrice pizza

let orderPrice(pizzas: Pizza list): int = 
    match pizzas with
        | [] -> 0
        | [a] -> 3 + pizzaPrice a
        | [a; b] -> 2 + pizzaPrice a + pizzaPrice b
        | _ -> List.map (fun x -> pizzaPrice x) pizzas |> List.sum
