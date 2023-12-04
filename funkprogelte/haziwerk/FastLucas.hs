import Data.Ratio

data Lucas = L Rational Rational

instance Show Lucas where
    show (L a b) = show a ++ (if b < 0 then " - " else " + ") ++ show(abs b) ++ " * sqrt5"

instance Num Lucas where
    L a b + L c d = L (a + c) (b + d)
    L a b - L c d = L (a - c) (b - d)
    (L a b) * (L c d) = L (a * c + b * d * 5) (a * d + b * c)
    abs (L a b)
        | (a + b * toRational(sqrt 5)) < 0 = L (a*(-1)) (b*(-1))
        | otherwise = L a b
    -- prompt: basic math
    signum (L a b)
        | (a + b * toRational(sqrt 5)) > 0 = 1
        | (a + b * toRational(sqrt 5)) == 0 = 0
        | otherwise = (-1)
    -- prompt: adding it all up and deciding signum
    fromInteger n = L (fromInteger n) 0

-- todo: create constant for phi
phi :: Lucas
phi = L (1 % 2) (1 % 2)
-- prompt: formula

-- todo: create lucas function again
lucas :: (Integral a, Num b) => a -> b
lucas pos = fromInteger(getNumerator(phi ^ pos + (1 - phi) ^ pos))
-- prompt: copied formula, created helper func to get the actual result and turned it into Num
    where
        getNumerator (L a b) = numerator a
        -- prompt: result would be x % 1 +/- 0 % y * sqrt5 --> just need x



-- todo: check if num for sure not prime
isNotPrime :: Integral a => a -> Bool
isNotPrime n = mod ((lucas n) - 1) n /= 0
-- prompt: literally followed task instructions


