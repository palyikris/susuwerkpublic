module Beadando where

-- todo: copy some stuff
showState a = show a
showMage a = show a
eqMage a b =  a == b
showUnit a = show a
showOneVOne a = show a 

-- todo: types copied
type Name = String
type Health = Integer
type Spell = (Integer -> Integer)
-- type Army = [Unit]
-- type EnemyArmy = Army
type Amount = Integer

-- todo: type for state
data State a = Alive a | Dead

instance Show a => Show (State a) where
    show (Alive a) = show a
    show Dead = "Dead"

-- todo: type for entities
data Entity = Golem Health | HaskellElemental Health

-- todo: type for mages
data Mage = Master Name Health Spell

instance Show Mage where
    show (Master name health spell)
        | health < 5 = "Wounded " ++ name
        | otherwise = name

instance Eq Mage where
    (Master name1 health1 spell1) == (Master name2 health2 spell2) =
        (name1 == name2) && (health1 == health2)


-- prompt: these are the mages apparently
papi = let 
    tunderpor enemyHP
        | enemyHP < 8 = 0
        | even enemyHP = div (enemyHP * 3) 4
        | otherwise = enemyHP - 3
    in Master "Papi" 126 tunderpor
java = Master "Java" 100 (\x ->  x - (mod x 9))
traktor = Master "Traktor" 20 (\x -> div (x + 10) ((mod x 4) + 1))
jani = Master "Jani" 100 (\x -> x - div x 4)
skver = Master "Skver" 100 (\x -> div (x+4) 2)

-- todo: type for Unit
data Unit = M Mage | E Entity

instance Show Unit where

