module Bob (responseFor) where

import Data.Char (isUpper, isAlpha, isSpace)

responseFor :: String -> String
responseFor xs
    | isSilence xs = "Fine. Be that way!"
    | isYelling xs && isQuestion xs = "Calm down, I know what I'm doing!"
    | isYelling xs = "Whoa, chill out!"
    | isQuestion xs = "Sure."
    | otherwise = "Whatever."

isYelling :: String -> Bool
isYelling str = any isUpper alphabeticChars && all isUpper alphabeticChars
    where 
        alphabeticChars = filter isAlpha str

isQuestion :: String -> Bool
isQuestion str = not (null str) && last (reverse $ dropWhile isSpace $ reverse str) == '?'

isSilence :: String -> Bool
isSilence str = all isSpace str
