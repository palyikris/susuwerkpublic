module RPN where

-- ! no partial functions

data Postfix = Constant Integer (Maybe Postfix) | Function (Integer -> Integer -> Integer) (Maybe Postfix)
-- prompt: just followed instructions


evaluatePostfix :: Postfix -> Maybe Integer
evaluatePostfix list = helper list []
    where
        -- task: cases w constants
        helper (Constant el Nothing) [] = Just el
        -- prompt: if there is no next, and no stack, then it is the result --> Just el
        helper (Constant el Nothing) stack = Nothing
        -- prompt: if there is no next, but there is a stack, then it is an error --> Nothing
        helper (Constant el (Just next)) stack = helper next (el:stack)
        -- prompt: if there is a next, then push the element to the stack and go on

        -- task: cases w functions
        helper (Function op Nothing) [x,y] = Just (op y x)
        -- prompt: if there is no next, but there are two els in stack, do operation then return the result
        helper (Function op (Just next)) (x:y:stack) = helper (Constant (op y x) (Just next)) stack
        -- prompt: if there is a next, then operate on the first two els in stack and continue
        helper _ _ = Nothing
        -- prompt: if none of the above --> must be an error --> Nothing
