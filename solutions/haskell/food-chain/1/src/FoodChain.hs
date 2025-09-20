module FoodChain (song) where
import Data.List (intercalate)

animal :: [String]
animal = ["fly", "spider", "bird", "cat", "dog", "goat", "cow", "horse"]

comment :: [String]
comment = [
      ""
    , "It wriggled and jiggled and tickled inside her.\n"
    , "How absurd to swallow a bird!\n"
    , "Imagine that, to swallow a cat!\n"
    , "What a hog, to swallow a dog!\n"
    , "Just opened her throat and swallowed a goat!\n"
    , "I don't know how she swallowed a cow!\n"
    , "She's dead, of course!\n"]

intro :: Int -> String
intro n = "I know an old lady who swallowed a " ++ animal !! n ++
          ".\n" ++ comment !! n

recap :: Int -> String
recap 0 = "I don't know why she swallowed the fly. Perhaps she'll die.\n"
recap n = "She swallowed the " ++ animal !! n ++ " to catch the " ++
          animal !! (n - 1) ++ coda n
    where
        coda 2 = " that wriggled and jiggled and tickled inside her.\n"
        coda _ = ".\n"
verse :: Int -> String
verse 7 = intro 7
verse n = intro n ++ concat [recap i | i <- [n, n - 1 .. 0]]

song :: String
song = intercalate "\n" [verse n | n <- [0..7]]