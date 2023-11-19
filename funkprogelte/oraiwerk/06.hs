module 06 where

-- todo: 1 [2,3] --> [[1,2,3], [2,1,3], [2,3,1]]
insertions :: a -> [a] -> [[a]]
insertions a [] = [[a]]
insertions a list@(x:xs) = (a:list) : [x: ys | ys <- insertions a xs]
-- ! nev@valami -> hivatkozas az adott valtozora


-- todo: permutations [1,2,3] --> [[1,2,3], [2,1,3], [2,3,1], [1,3,2], [3,1,2], [3,2,1]]
permutations :: [a] -> [[a]]
permutations [] = [[]]
permutations list@(x:xs) = [zs | ys <- permutations xs, zs <- insertions x ys ]


-- definition: Parametrikusan polimorf függvény: Olyan függvény, amely működése nem függ a paraméter típusától
-- example: pl.: (:), head, tail, last, insertions, permutations

-- definition: Ad-hoc polimorf függvény: Olyan függvény, amely működése függ a paraméter típusától
-- example: pl.: (+), (-), (*), fromIntegral

-- ! Haskell-ben ez úgy néz ki:
-- def: Parametrikusan polimorf: A függvény típusában nincs típusmegkötés
-- def: Ad-hoc polimorf: A függvény típusában van típusmegkötés

-- todo: reverse the elements of a list
reverse' :: [a] -> [a]
reverse' [] = []
reverse' (x:xs) = reverse' xs ++ [x]
-- optimize: its shit


-- todo: reverse the elements of a list but better
reverse'' :: [a] -> [a]
reverse'' xs = reverseAcc [] xs where
    reverseAcc :: [a] -> [a] -> [a]
    reverseAcc acc [] = acc
    reverseAcc acc (x:xs) = reverseAcc (x:acc) xs

-- example reverseAcc [] [1,2,3] = 
-- example reverseAcc (1:[]) [2,3] = 
-- example reverseAcc (2:(1:([]))[3] = 

-- notes: végtelen lisára nem működik!!!
-- notes: ha átpakolom a listaelemeket a másik listába, akkor "mágikusan megfordulnak"


