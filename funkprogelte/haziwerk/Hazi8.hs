import Data.List

-- todo: apply list of function on elements of lists of a list for Task 1
apsOnLists :: [a -> b] -> [[a]] -> [[b]]
apsOnLists [] _ = []
apsOnLists _ [] = []
-- prompt: if one of the lists is empty, return empty list
apsOnLists funcs lists = zipWith map funcs lists
-- idea: otherwise apply the nth function to the elements of the nth list
-- prompt: cuts off lists if longer than funcs


-- todo: lucas but diff for Task 2
lucas :: [Integer]
lucas = 2 : 1 : zipWith (+) lucas ( tail lucas)
-- prompt: zipwith --> applies a binary func to two lists
-- idea: first list is the lucas list being generated and second is the same without 
-- idea: the first element --> it is always on element behind --> adds corresponding elements

-- todo: list all sublists for Task 3
sublists :: [a] -> [[a]]
sublists = ([]:) . filter (not . null) . concatMap tails . inits
-- prompt: then almost have solution, but riddled with empty lists
-- sublists = [] : ((filter (not . null)) . (concatMap tails . inits))
-- example: sublists list = [] : filter (not . null) (concatMap(tails)(inits list))
-- prompt: then almost have solution, but riddled with empty lists
-- idea: provide missing argument to the dot operator
-- idea: need to filter out empty lists
-- idea: but then one will be missing from the beginning so --> [] : func

-- todo: del an element every possible way
deletionsBy :: (a -> Bool) -> [a] -> [[a]]
deletionsBy _ [] = []
-- prompt: return null if input list empty
deletionsBy f (x:xs)
    | f x = xs : map (x:) (deletionsBy f xs)
    -- idea: if the curr element satisfies the input function, delete it --> xs :
    -- idea: also keep deleting while appending the curr deleted element to all the future lists
    | otherwise = map (x:) (deletionsBy f xs)
    -- prompt: the same as above without deleting the curr element

-- todo: define functions with the foldr function
map' :: (a -> b) -> [a] -> [b]
map' f = foldr (\x acc -> f x : acc) []
-- prompt: iterate thru elements and append every x to the acc after applying f on it

filter' :: (a -> Bool) -> [a] -> [a]
filter' f = foldr(\x acc -> helper f x acc) []
    where
        helper f x acc
            | f x = x : acc
            | otherwise = acc
-- prompt: same as map but only append x if fits the condition

takeWhile' :: (a -> Bool) -> [a] -> [a]
takeWhile' f list = foldr(\x acc -> fst(span f x) ++ acc ) [] [list]
-- prompt: instead of if else used the formula for dropWhile'


dropWhile' :: (a -> Bool) -> [a] -> [a]
dropWhile' f list = foldr(\x acc -> snd(span f x) ++ acc) [] [list]
-- idea: put the input list in list
-- idea: use span with the condition --> ([elems of takeWhile, elems of dropWhile])
-- idea: add the second two acc

splitOn' :: (a -> Bool) -> [a] -> [[a]]
splitOn' f = foldr (\x acc -> helper f x acc) [[]]
    where
        helper f x acc
            | f x = []:acc
            | otherwise = (x:(head acc)) : (tail acc)
-- prompt: same as done when had to use recursion but integrated into a foldr










