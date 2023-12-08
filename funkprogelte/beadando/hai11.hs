module RPN where

data Postfix =
    Constant Integer (Maybe Postfix)
    |
    Function (Integer -> Integer -> Integer) (Maybe Postfix)

-- evaluatePostfix :: Postfix -> Maybe Integer
-- evaluatePostfix ( Constant x Nothing ) = Just x
-- evaluatePostfix ( Function f Nothing ) = Nothing
-- evaluatePostfix ( Constant x (Just (Constant y (Just (Function f Nothing ) ) ) ) ) = Just (f x y)

evaluatePostfix :: Postfix -> Maybe Integer
evaluatePostfix input = solve input [] where
    solve (Constant x Nothing) [] = Just x --eremény
    solve (Constant x Nothing) s  = Nothing --eredmény lenne de van még stack
    solve (Constant x (Just next)) s = solve next (x:s) --konstans eltárolása

    solve (Function f Nothing) [x,y] = Just (f y x) -- eredmény
    solve (Function f (Just next)) (x:y:stack) = solve (Constant (f y x) (Just next)) stack --függvény kiszámolása
    solve _ _ = Nothing --hiba