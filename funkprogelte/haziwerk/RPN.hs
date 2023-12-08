module RPN where

-- ! no partial functions

data Postfix = Constant Integer (Maybe Postfix) | Function (Integer -> Integer -> Integer) (Maybe Postfix)
-- prompt: just followed instructions


evaluatePostfix :: Postfix -> Maybe Integer
evaluatePostfix input = helper input [] where
    helper (Constant x next) [] 
        | isNothing next = Just x
        | otherwise = Nothing
        where 
                isNothing Nothing = True
                isNothing _ = False
    helper (Constant x next) s = helper (next) (x:s)
    helper (Function f next) (x:y:stack) = helper (maybe (Constant (f y x) Nothing) (Constant (f y x)) (Just next)) stack
    helper _ _ = Nothing

