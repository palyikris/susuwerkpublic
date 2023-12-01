module FastLucas where
import Data.Ratio

-- todo: create data and instances
data Lucas = L Rational Rational

instance Show Lucas where
    show (L a b) = show a ++ (if b < 0 then " - " else " + ") ++ show(abs b) ++ " * sqrt5"

instance Num Lucas where
    L a b + L c d = L (a + c) (b + d)
    L a b - L c d = L (a - c) (b - d)
    (L a b) * (L c d) = L (a * c + b * d * 5) (a * d + b * c)
    abs(L a b) = L (abs a) (abs b)
    signum (L a b) = L (signum a) (signum b)
    fromInteger n = L (fromInteger n) 0

-- todo: create constant for phi
phi :: Lucas
phi = L (1 % 2) (1 % 2)

-- todo: create lucas function again
lucas :: (Integral a, Num b) => a -> b




