module Hazi1 where


-- todo: Create three ints
intExpr1 :: Int
intExpr1 = 1

intExpr2 :: Int
intExpr2 = 2

intExpr3 :: Int
intExpr3 = 3

-- todo: Create three chars
charExpr1 :: Char
charExpr1 = '1'

charExpr2 :: Char
charExpr2 = '2'

charExpr3 :: Char
charExpr3 = '3'

-- todo: Create three bools
boolExpr1 :: Bool
boolExpr1 = True

boolExpr2 :: Bool
boolExpr2 = False

boolExpr3 :: Bool
boolExpr3 = True && False

-- todo: inc function adding 1
inc :: Int -> Int
inc x = x + 1

-- todo: triple function multiplying with 3
triple :: Int -> Int
triple x = x * 3

-- todo: make expression resulting thirteen
thirteen1 :: Int
thirteen1 = inc(triple(inc(triple(inc 0))))

thirteen2 :: Int
thirteen2 = inc(inc(inc(inc(inc(inc(inc(triple(inc(inc 0)))))))))

thirteen3 :: Int
thirteen3 = inc(inc(inc(inc(triple(triple(inc(triple(0))))))))

-- todo: function to decide if an int divided by five has a greater remainder than if divided by 7
cmpRem5Rem7 :: Int -> Bool
cmpRem5Rem7 x = mod x 5 > mod x 7

-- todo: simple function doing sth but has given type
foo :: Int -> Bool -> Bool
foo x y = mod x 2 == 0 && y

-- todo: create simplest function using the one above
bar :: Bool -> Int -> Bool
bar x y = foo y x
