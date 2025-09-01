module DndCharacter

open System

let modifier x = 
    if x < 10 && x % 2 = 1 then
        (x - 10) / 2 - 1
    else
        (x - 10) / 2

let ability() = 
    let dice = new Random()
    let four = [1..4] |> List.map (fun x -> dice.Next(1, 6)) |> List.sort
    match four with
    | small::rest -> rest
    | [] -> []
    |> List.sum
    
type Character = {
    Strength: int
    Dexterity: int
    Constitution: int
    Intelligence: int
    Wisdom: int
    Charisma: int
    Hitpoints: int
}

let createCharacter() =
    let character = {
        Strength = ability()
        Dexterity = ability()
        Constitution = ability()
        Intelligence = ability()
        Wisdom = ability()
        Charisma = ability()
        Hitpoints = 0
    }
    { character with Hitpoints = 10 + modifier character.Constitution }
