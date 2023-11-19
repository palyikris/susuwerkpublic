module Hazi3 where
import Data.List (group)


-- ! types
type Title = String

-- todo: letter counter rec. function for first task
o_O_count :: Num count => Title -> count
o_O_count [] = 0
o_O_count ('o':xs) = 1 + o_O_count xs
o_O_count ('O':xs) = 1 + o_O_count xs
o_O_count (x:xs) = o_O_count xs

-- todo: list length rec. function for second task
longerThan :: Integral count => [item] -> count -> Bool
longerThan [] listLength = listLength < 0 
longerThan (_:xs) listLength = listLength <= 0 || longerThan xs (listLength - 1)

-- todo: merging rec. function for third task
merge :: [magic] -> [magic] -> [magic]
merge [] ys = ys
merge xs [] = xs
merge (x:xs) (y:ys) = x : y : merge xs ys

-- todo: function to decide for fourth task
starter :: Eq magic => [magic] -> [magic] -> Bool
starter [] _ = True
starter _ [] = False
starter (x:xs) (y:ys) = x == y && starter xs ys

-- todo: function to print endings for fifth task
endings :: [magic] -> [[magic]]
endings [] = [[]]
endings (x:xs) = (x:xs) : endings xs

