-- pagefor: 6th homework until 11.06

-- todo: writing a split function for Task 1
splitOn :: Eq a => a -> [a] -> [[a]]
splitOn sepChar (x:xs) -- idea: if the string has more elements the same two options as before
    | x == sepChar = [] : splitOn sepChar xs 
    -- prompt: if the current element is the separator, close sublist, create new sublist and keep separating
    | otherwise = (x : head (splitOn sepChar xs)) : tail (splitOn sepChar xs) 
    -- idea: if current element is not separator, append it to the current sublist
splitOn _ _ = [[]]

-- todo: return empty lines for Task 2
emptyLines :: Num a => String -> [a]
emptyLines string = helpWithEmLines 1 (splitOn '\n' string)
-- idea: need to bring in a helper function with a number so that i can keep track of the index im at
-- idea: using spliton for this, cuz if i split on \n, it will return [] for every empty line
    where
        helpWithEmLines _ [] = []
        -- prompt: if the string is empty return empty string -> base case 
        helpWithEmLines szam (x:xs) 
        -- prompt: if the string is not empty we have two options, the x is an empty list or not
            | null x = szam : helpWithEmLines (szam+1) xs 
            -- idea: if x is an empty list, return the number which is the index of that empty line and call the function
            -- idea: while increasing the variable that keeps track of the index
            | otherwise = helpWithEmLines (szam+1) xs
            -- idea: otherwise just keep calling the function while increasing the index

-- todo: csv processing function for Task 3
csv :: String -> [[String]]
csv [] = []
-- prompt: if empty string --> nothing to do
csv string = helpWithCsv (splitOn '\n' string)
-- idea: need to make a hierarchy so call a helper function and split the string by the \n
    where
        -- prompt: if the splitted string has no elements return an empty list
        helpWithCsv [] = []
        helpWithCsv (x:xs)
        -- prompt: if we have elements there are two options
            | null x = [] : helpWithCsv xs
            -- idea: if the current element in the splitted string is a []
            -- idea: have to leave it that way, just add a [] and keep on going
            | otherwise = (splitOn ',' x) : helpWithCsv xs
            -- idea: if the current element of the splitted string is a non-empty list
            -- idea: have to split its content by the commas, and keep calling the helper function