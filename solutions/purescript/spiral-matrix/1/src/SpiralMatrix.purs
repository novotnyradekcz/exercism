module Spiral
  ( spiral
  ) where

import Prelude
import Data.List (List(Nil), (..))

go :: Int -> Int -> Int -> Int
go x 1 _ = x
go x y w = w `div` 2 + go (y - 1) (w `div` 2 - x + 1) (w - 1)

spiral :: Int -> List (List Int)
spiral 0 = Nil
spiral s = do
  x <- 1..s
  pure $ do
    y <- 1..s
    pure $ go y x (s * 2)
