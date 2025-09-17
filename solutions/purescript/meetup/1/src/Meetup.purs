module Meetup
  ( meetup
  , Week(..)
  ) where

import Prelude

import Data.Date (Date, Month, Weekday, Year, adjust, canonicalDate, weekday, lastDayOfMonth)
import Data.Enum (fromEnum, toEnum)
import Data.Maybe (Maybe(..))
import Data.Time.Duration (Days(..))
import Partial.Unsafe (unsafeCrashWith)

data Week = First | Second | Third | Fourth | Last | Teenth

meetup :: Year -> Month -> Week -> Weekday -> Maybe Date
meetup y m w d = f $ canonicalDate y m <$> toEnum l
  where
    l = case w of
      First   -> 7
      Second  -> 14
      Third   -> 21
      Fourth  -> 28
      Last    -> fromEnum $ lastDayOfMonth y m
      Teenth  -> 19
    f c@(Just d')
      | weekday d' == d = c
      | otherwise = f $ (adjust $ Days (-1.0)) d'
    f _ = unsafeCrashWith "Impossible"
