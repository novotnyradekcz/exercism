module Allergies

open System

type Allergen =
    | Eggs = 1
    | Peanuts = 2
    | Shellfish = 4
    | Strawberries = 8
    | Tomatoes = 16
    | Chocolate = 32
    | Pollen = 64
    | Cats = 128

let allergicTo codedAllergies allergen =
    let maxAllergenScore = int (Allergen.Cats)
    let allergenScore = int allergen
    if allergenScore > maxAllergenScore then
        false
    else
        (codedAllergies &&& allergenScore) = allergenScore

let list codedAllergies =
    let allergens =
        [ Allergen.Eggs
          Allergen.Peanuts
          Allergen.Shellfish
          Allergen.Strawberries
          Allergen.Tomatoes
          Allergen.Chocolate
          Allergen.Pollen
          Allergen.Cats ]
    allergens |> List.filter (fun x -> allergicTo codedAllergies x)