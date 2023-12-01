data Complex = C Double Double
-- prompt:        a     + bi

instance Show Complex where
    show (C a b) = show a ++ (if b < 0 then " - " else " + ") ++ show(abs b) ++ "i"

instance Num Complex where
    C a b + C c d = C (a + c)(b + d)
    C a b - C c d = C (a - c)(b - d)
    C a b * C c d = C (a * c - b * d)(a * d - b * c)
    abs (C a b) = C (sqrt $ a^2 + b^2) 0
    signum (C a b) = let l = sqrt $ a^2 + b^2 in C (a/l) (a/l)
    fromInteger n = C (fromInteger n) 0

-- def: ronda fuggvenyek
-- example: head :: [a] -> a
-- example: div :: Integral a => a -> a -> a

data MaybeInt = NoInt | JustInt Int deriving Show

head' :: [Int] -> MaybeInt
head' [] = NoInt
head (x:_) = JustInt x
