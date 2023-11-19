module Hazi3 where
import Data.List (group)

-- ! types
type Room = String
type Air = Int
type Fire = Integer
type MagicLevel = Int


-- todo: roomfinder function for first task
find :: [Room] -> [Room]
find x = [helperVar | helperVar <- x, helperVar == "2.620"]

-- todo: magic integration for second task
add :: (Integral magic1, Integral magic2, Num magic3) => magic1 -> magic2 -> magic3
add magic1 magic2 = fromIntegral magic1 + fromIntegral magic2

-- todo: need a helper function to detect primes for third task
listDividers :: Int -> [Int]
listDividers num = [numHelp | numHelp <- [1..num], mod num numHelp == 0]

-- todo: need a helper function to detect primes for third task
isNumPrime :: [Int] -> Bool
--isNumPrime num = length [numHelp | numHelp <- [1..num], mod num numHelp == 0] == 2
isNumPrime [1, num] = True
isNumPrime _ = False

-- todo: return primes in a list between given numbers for third task
primeMagic :: MagicLevel -> MagicLevel -> [MagicLevel]
primeMagic magicLevel1 magicLevel2 = [magicLevelHelper | magicLevelHelper <- [magicLevel1..magicLevel2], isNumPrime(listDividers magicLevelHelper)]

-- todo: group letters in given input for fourth task   
compress :: Eq magic => [magic] -> [(magic, MagicLevel)]
compress spell = [(head magicTuple, length magicTuple) | magicTuple <- group spell]

-- todo: degroup letters in given input for fifth task
decompress :: [(magic, MagicLevel)] -> [magic]
decompress magicList = concat[(replicate count char) | (char, count) <- magicList]



