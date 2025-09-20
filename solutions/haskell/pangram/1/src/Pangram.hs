module Pangram (isPangram) where

import Data.Char (toLower, isAsciiLower)
import Data.List (nub)

isPangram :: String -> Bool
isPangram text = length (nub $ map toLower $ filter isAsciiLower text') == 26
  where text' = map toLower text
