-- pagefor: 5th homework until 11.06
import Data.Char (toUpper, isDigit, isSpace)



-- todo: make third letter uppercase for first task
toUpperThird :: String -> String
toUpperThird [] = []
toUpperThird [x] = [x] -- prompt: leaving it untouched cuz less than 3
toUpperThird [x,y] = [x,y] -- prompt: same
toUpperThird (x:y:z:xs) = x : y : toUpper z : xs
-- prompt: taking the string apart, uppercase the third element and put it back together


-- todo: check if list is sorted for second task
isSorted :: Ord a => [a] -> Bool
isSorted [] = True -- prompt: if no item, it is ordered
isSorted [_] = True -- prompt: if one item, it is ordered
isSorted (x:y:xs) = x <= y && isSorted (y:xs)
-- idea: checking if x is less or eq to y and if yes, those parts are sorted
-- idea: proceed with the function to check the remaining elements

-- todo: indexing into a list for third task
(!!!) :: Integral b => [a] -> b -> a
(!!!) [] _ = undefined -- prompt: cant get an element of an empty list
(!!!) (x:xs) indx
    -- prompt: then need to check if index is negative
    | indx == 0 = x
    | indx < 0 = (!!!) (reverse (x:xs)) (-indx - 1)
    -- prompt: if it is negative reverse the function and take the abs value of index minus 1
    -- prompt: that way we can index from the end of the list
    | otherwise = (!!!) (xs) (indx-1)

-- todo: add spaces to string for fourth task
format :: Integral b => b -> String -> String
-- idea: there are two main cases here --> either we get an empty string or a nonemtpy one
format limit []
    -- prompt: if its empty then keep adding spaces to it and reducing limit until it is zero
    | limit <= 0 = []
    | otherwise = ' ' : format (limit - 1) []
format limit (x:xs)
    -- prompt: if its not empty but the limit is zero we return the string otherwise keep calling format while reducing limit
    | limit <= 0 = (x:xs)
    | otherwise = x : format (limit-1) xs
 
-- todo: check if there was big wing for fifth task
mightyGale :: (Num a, Ord b, Num b, Integral c) => [(String, a, b, c)] -> String
mightyGale [] = ""
mightyGale ((name, deg, wind, day) : xs)
    | wind > 110 = name
    | otherwise = mightyGale xs

-- todo: get the first two chars before a number for sixth task
cipher :: String -> String
cipher (x:y:z:xs)
    | isDigit z = x : [y] -- idea: if the second element is a digit return the first two elements --> solution found
    | otherwise = cipher (y:z:xs) -- idea: else call the function again with the rest of the list
cipher x = ""

-- todo: double all the elements in a list for seventh task   
doubleElements :: [a] -> [a]
doubleElements [] = [] -- prompt: if list is empty return empty list
doubleElements (x:xs) = x : x : doubleElements xs -- idea: otherwise return the element doubled and call the function again with the rest of the list  

-- todo: delete duplicate spaces for eighth task
deleteDuplicateSpaces :: String -> String
deleteDuplicateSpaces "" = "" -- prompt: if list is empty return empty list obvly
deleteDuplicateSpaces (x:xs) 
    | isSpace x = deleteDuplicateSpaces xs -- prompt: first i delete the spaces before the first word
    | otherwise = helpWithDeletion (x:xs) -- prompt: then call the helper function
    where
        helpWithDeletion "" = "" -- prompt: this is helpful when the last space is deleted and the function is recalled
        helpWithDeletion (x:xs)
            | isSpace x && null xs = helpWithDeletion xs -- prompt: deleting the last space
            | null xs = [x] -- prompt: if list has only one element left return the element
            | isSpace x && isSpace (head xs) = helpWithDeletion xs -- idea: if the first two elements are spaces call the function again with the rest of the list
            -- idea: this way it will delete the duplicate spaces but will keep one
            | otherwise = x : helpWithDeletion xs -- prompt: this ensures that the first element is always added to the list --> no duplicate spaces but one space remains

-- todo: make lucas sequence for ninth task
lucas :: (Integral a, Num b) => a -> b
lucas num 
    | num < 0 = 0 -- prompt: if number is negative return 0
    | num == 0 = 2 -- prompt: if number is 0 return 2 --> given in the task
    | num == 1 = 1 -- prompt: if number is 1 return 1 --> given in the task
    | otherwise = lucas (num - 1) + lucas (num - 2) -- idea: else return the sum of the two previous numbers in the sequence
    -- idea: since the nth number is the sum of the two previous numbers in the sequence if we get them we get the nth number



