module Allergies exposing (Allergy(..), isAllergicTo, toList)


type Allergy
    = Eggs
    | Peanuts
    | Shellfish
    | Strawberries
    | Tomatoes
    | Chocolate
    | Pollen
    | Cats


allergyScores : List (Allergy, Int)
allergyScores =
    [ (Eggs, 1)
    , (Peanuts, 2)
    , (Shellfish, 4)
    , (Strawberries, 8)
    , (Tomatoes, 16)
    , (Chocolate, 32)
    , (Pollen, 64)
    , (Cats, 128)
    ]


isAllergicTo : Allergy -> Int -> Bool
isAllergicTo allergy score =
    case List.filter (\(a, _) -> a == allergy) allergyScores of
        [( _, allergyScore )] ->
            modBy 2 (score // allergyScore) == 1
        _ ->
            False


toList : Int -> List Allergy
toList score =
    allergyScores
        |> List.filter (\(_, allergyScore) -> modBy 2 (score // allergyScore) == 1)
        |> List.map Tuple.first
