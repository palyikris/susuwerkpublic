module Beadando where
import Data.List


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
type Army = [Unit]
type EnemyArmy = Army
type Amount = Integer

-- todo: type for state
data State a = Alive a | Dead deriving Eq

instance Show a => Show (State a) where
    show (Alive a) = show a
    show Dead = "Dead"

-- todo: type for entities
data Entity = Golem Health | HaskellElemental Health deriving (Show, Eq)

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
data Unit = M (State Mage) | E (State Entity) deriving Eq

instance Show Unit where
    show (M unit) = show unit
    show (E unit) = show unit

-- todo: function for rearranging army
formationFix :: Army -> Army
formationFix army = filter isAlive army ++ filter isDead army
    -- idea: create two lists
    -- idea: the first is filtered for those units that are alive --> they will be at  the front
    -- idea: the second is filtered for the dead --> will be at the back
    where
        isAlive (E (Alive _)) = True
        isAlive(M (Alive _)) = True
        -- prompt: whatever is alive will result true
        isAlive _ = False
        isDead (E Dead) = True
        isDead (M Dead) = True
        -- prompt: whatever is dead will result true
        isDead _ = False
        -- prompt: these are needed for the filters so that they can filter out the alive or dead

-- todo: check if all is dead in an army
over :: Army -> Bool
over [] = True
over list = (filter isAlive list) == []  
    where
        isAlive (E (Alive _)) = True
        isAlive(M (Alive _)) = True
        -- prompt: whatever is alive will result true
        isAlive _ = False


-- prompt: had to copy this
potionMaster = 
  let plx x
        | x > 85  = x - plx (div x 2)
        | x == 60 = 31
        | x >= 51 = 1 + mod x 30
        | otherwise = x - 7 
  in Master "PotionMaster" 170 plx

-- todo: create function for fighting
wound :: Spell -> Unit -> Unit
wound spell (E (Alive (Golem h)))
    | spell h <= 0 = E (Dead)
    | otherwise = E (Alive (Golem (spell h)))
wound spell (E (Alive (HaskellElemental h)))
    | spell h <= 0 = E (Dead)
    | otherwise = E (Alive (HaskellElemental (spell h)))
wound spell (M (Alive (Master n h s)))
    | spell h <= 0 = M (Dead)
    | otherwise = M (Alive (Master n (spell h) s))
-- prompt: this is the same for three diff types of units
-- prompt: first check if spell kills unit --> return dead unit
-- prompt: otherwise return alive unit with the health changed by the spell
-- idea: the spell in case of golems and haskell elementals is just a subtraction


fight :: EnemyArmy -> Army -> Army
fight [] army = army
fight enemyArmy [] = []
-- prompt: base cases

fight ((E (Alive( Golem h))):enemyArmy) (unit:army) = wound (\x -> x-1) unit : fight enemyArmy army
-- prompt: if enemy is golem --> wound by 1

fight ((E (Alive( HaskellElemental h))):enemyArmy) (unit:army) = wound (\x -> x-3) unit : fight enemyArmy army
-- prompt: if enemy is haskell --> wound by 3

fight ((M (Alive( Master n h s))):enemyArmy) (unit:army) = wound s unit : map (wound s) (fight enemyArmy army)
-- idea: if enemy is mage --> wound unit by spell and then wound the rest of the army by the spell but recursion cant stop
-- idea: map is used to apply the wound to the rest of the army while
-- idea: first unit is wounded in the beginning --> in map i can wound the rest while the fight happens

-- ! cases when the enemy is alive
fight (_:enemyArmy) (_:army) = fight enemyArmy army
-- prompt: only case left is when the enemy is dead
-- idea: just skip

-- todo: create blasting function
haskellBlast :: Army -> Army
haskellBlast [] = []
-- prompt: base case
haskellBlast (unit1:unit2:unit3:unit4:unit5:unit6:army)
    | (helper unit1) || (helper unit2) || (helper unit3) || (helper unit4) || helper (unit5) = haskellBlast (unit2:unit3:unit4:unit5:unit6:army)
    | otherwise = haskellBlast (unit1:unit2:unit3:unit4:unit5:[])
        where 
            helper (M (Alive (Master n h s))) = h >= 5
            helper (E (Alive (HaskellElemental h))) = h >= 5
            helper (E (Alive (Golem h))) = h >= 5
            helper _ = False
-- prompt: pattern match to at least 6 elements
haskellBlast (unit:army) = wound (\x -> x-5) unit : haskellBlast army
-- prompt: rest of the cases --> wound by 5 --> doesnt have to look for more damage



