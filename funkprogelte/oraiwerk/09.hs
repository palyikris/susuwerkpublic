-- pagefor: 9. óra

reverse' :: [a] -> [a]
reverse' = reverseAcc []
    where
        reverseAcc acc [] = acc
        reverseAcc acc (x:xs) = reverseAcc (x:acc) xs
    

genL :: (b -> a -> b) -> b -> [a] -> b
genL f acc [] = acc
genL f acc (x:xs) = genL f (f acc x) xs
-- prompt: this is how foldl works

reverse'' :: [a] -> [a]
reverse'' = foldl (\acc x -> x:acc) []
-- def: defining reverse using foldl



-- Tipusszinonima:
type Fire = Int
type Air = Integer

f :: Air -> Fire
f 0 = 2
f 1 = 0
f x = fromIntegral x+2


type Predicate a = a -> Bool
filter' :: Predicate a -> [a] -> [a]
filter' _ [] = []
filter' p (x:xs)
    | p x = x : filter' p xs
    | otherwise = filter' p xs


-- def: Tipusszinonoima nem tud semmivel se tobbet, mint az elnevezett tipus.
-- example: type String = [Char]

-- Saját típusok:
data Day = 
    -- prompt: meg kell adni a típusom értékeit, konstruktorait
    -- prompt: konstruktorok nevei nagybetűvel kezdődnek
    Mon | Tue | Wed | Thu | Fri | Sat | Sun
    -- prompt: meg lehet kérni a fordítót különböző dolgokra
    deriving (Show, Enum)
    -- prompt: 7 dologra lehet megkérni a fordítót
    -- example: Show
    -- example: Read
    -- example: Eq
    -- example: Ord
    -- example: Bounded
    -- example: Enum
    -- example: Ix


nextDay :: Day -> Day
nextDay Mon = Tue
nextDay Tue = Wed
nextDay Wed = Thu
nextDay Thu = Fri
nextDay Fri = Sat
nextDay Sat = Sun
nextDay Sun = Mon

not' :: Bool -> Bool
not' True = False
not' False = True

-- def: data Bool = False | True

-- def data (a,b) = (,) a b

type Red = Int
type Green = Int
type Blue = Int
data Color = RGB Red Green Blue
    deriving (Show)

modifyColor :: Color -> Red -> Green -> Blue -> Color
modifyColor col@(RGB r g b) r' g' b' 
    | 0 <= red && red >= 255 
    && 0 <= green && green >= 255
    && 0 <= blue && blue >= 255 = RGB red green blue
    | otherwise = col
    where
        red = r + r'
        green = g + g'
        blue = b + b'

-- def: "okos" konstruktorok
rgb :: Red -> Green -> Blue -> Color
rgb r g b
    | 0 <= r && r >= 255 
    && 0 <= g && g >= 255
    && 0 <= b && b >= 255 = RGB r g b
    | otherwise = error "Valamelyik szin tartomanyon kivul van!"

data Fruit = Apple | Pear | Peach deriving Show
data FruitBatch = FruitBatch Fruit Integer deriving Show

sumFruit :: [FruitBatch] -> Integer
sumFruit [] = 0
sumFruit ((FruitBatch _ n):xs) = n + sumFruit xs

sumDiffFruit :: [FruitBatch] -> (FruitBatch, FruitBatch, FruitBatch)
sumDiffFruit [] = (FruitBatch Apple 0, FruitBatch Pear 0, FruitBatch Peach 0)
sumDiffFruit ((FruitBatch Apple n):xs) = 
sumDiffFruit ((FruitBatch Pear n):xs) = 
sumDiffFruit ((FruitBatch Peach n):xs) = 






