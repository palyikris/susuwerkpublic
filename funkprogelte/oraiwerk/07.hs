-- def: Névtelen függvények : Lambda-függvények

map' :: (a -> b) -> [a] -> [a]
map' f [] = []
map' f (x:xs) = f x : map' f xs

-- ! a -> b -> c = a -> (b -> c)
-- def: curryzés elve: Minden függvény egyparaméteres
-- example: parciális applikálás / parciális függvényalkalmazás
    -- def: Egy függvénynek nem adom át az összes szükséges paraméterét, hogy "eredményt" adjon vissza