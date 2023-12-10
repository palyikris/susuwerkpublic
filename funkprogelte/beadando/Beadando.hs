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
wound spell unit = unit
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
fight (_:enemyArmy) (unit:army) = unit : fight enemyArmy army
-- prompt: only case left is when the enemy is dead
-- idea: just skip



-- todo: create blasting function
getHealth :: Unit -> Health
getHealth (E (Alive (Golem h))) = h
getHealth (E (Alive (HaskellElemental h))) = h
getHealth (M (Alive (Master _ h _))) = h
getHealth _ = 0
-- prompt: get the health prop of creature

sumHealth :: Army -> Health
sumHealth [] = 0
sumHealth (unit:army)
    | unit == (E Dead) = 0 + sumHealth army
    | unit == (M Dead) = 0 + sumHealth army
    | getHealth(unit) > 5 = 5 + sumHealth army
    | otherwise = getHealth(unit) + sumHealth army
-- prompt: sum the dam that can be done to segment

getArea :: Int -> Army -> Army
getArea 0 army = []
getArea n [] = []
getArea n army = take 5 (drop n army) 
-- prompt: get the 5 elements starting from the nth element

findArea :: Army -> Int
findArea (u1:u2:u3:u4:u5:u6:army) = helper 0 0 (sumHealth (u1:u2:u3:u4:u5:[])) (getArea 0 army) (u1:u2:u3:u4:u5:u6:army)
    where
        helper _ maxIndex _ [_,_,_,_] _ = maxIndex
        -- prompt: stop if there are less than 5 elements left
        helper currIndex maxIndex maxHealth currArea army
            | maxHealth >= 25 = maxIndex
            -- prompt: this case is the best it can be --> stop
            | maxHealth < (sumHealth currArea) = helper (currIndex+1) currIndex (sumHealth currArea) (getArea (currIndex+1) army) army
            -- prompt: if the current area is better --> update the max
            | otherwise = helper (currIndex+1) maxIndex maxHealth (getArea (currIndex+1) army) army
            -- prompt: otherwise keep going
findArea _ = 0
-- prompt: if area length <= 5 --> return 0

haskellBlast :: Army -> Army
haskellBlast [] = []
-- prompt: base case
haskellBlast (unit1:unit2:unit3:unit4:unit5:unit6:army) = fst(splitAt (findArea (unit1:unit2:unit3:unit4:unit5:unit6:army)) (unit1:unit2:unit3:unit4:unit5:unit6:army)) ++ (haskellBlast (take 5 (snd(splitAt (findArea (unit1:unit2:unit3:unit4:unit5:unit6:army)) (unit1:unit2:unit3:unit4:unit5:unit6:army))))) ++ (drop 5 (snd(splitAt (findArea (unit1:unit2:unit3:unit4:unit5:unit6:army)) (unit1:unit2:unit3:unit4:unit5:unit6:army))))
-- idea: this seems nasty but the gist:
-- idea: find the starting index of the best area
-- idea: split the army into two parts
-- idea: first untouched ++ wounded second(five elements long) ++ untouched second
haskellBlast (unit:army) = wound (\x -> x-5) unit : haskellBlast army
-- prompt: if army length <= 5 --> just wound all by 5

-- todo: create function for healing
heal :: Unit -> Unit
heal (M (Alive (Master n h s))) = M (Alive (Master n (h+1) s))
heal (E (Alive (HaskellElemental h))) = E (Alive (HaskellElemental (h+1)))
heal (E (Alive (Golem h))) = E (Alive (Golem (h+1)))
heal unit = unit
-- prompt: heal by 1 --> return the healed unit
-- prompt: if unit is dead --> return dead unit

isDead :: Unit -> Bool
isDead (M Dead) = True
isDead (E Dead) = True
isDead _ = False
-- prompt: check if unit is dead

-- idea: this function iterates thru the army and heals the units that are alive
-- idea: returns a tuple with the remaining health and the healed army
armyHeal :: Health -> Army -> (Health, Army)
armyHeal 0 army = (0, army)
armyHeal health [] = (health, [])
armyHeal health (unit:army)
    | not (isDead unit) = (fst (armyHeal (health-1) army), heal unit : snd (armyHeal (health-1) army))
    | otherwise = (fst (armyHeal health army), unit : snd (armyHeal health army))

-- idea: this function uses armyHeal to heal the army multiple times --> unitl the health is 0
multiHeal :: Health -> Army -> Army
multiHeal 0 army = army
multiHeal health [] = []
multiHeal health army
    | over army = army
    | health <= 0 = army
    | otherwise = multiHeal (fst (armyHeal health army)) (snd (armyHeal health army))

-- todo: create battle function
battle :: Army -> EnemyArmy -> Maybe Army {- vagy Maybe EnemyArmy -}
battle [] [] = Nothing
-- prompt: obviously if both are empty --> return nothing
battle [] enemyArmy = Just enemyArmy
battle army [] = Just army
-- prompt: if one army empty --> other one is the winner
battle army enemyArmy
    | over army && over enemyArmy = Nothing
    -- prompt: if both are over --> return nothing
    | over army = Just enemyArmy
    | over enemyArmy = Just army
    -- prompt: if one army is over --> the other one is the winner
    | otherwise = battle (formationFix(multiHeal 20 (haskellBlast (fight enemyArmy army)))) (formationFix(fight army enemyArmy))
    -- prompt: keep battling till one of the above happens
    -- prompt: also my army gets blasted and healed each turn




