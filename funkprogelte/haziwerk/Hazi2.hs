
-- todo: add function for first task
inc :: Int -> Int
inc x = x + 1

-- todo: healing function with inc
lesser_heal :: Int -> Int
lesser_heal x = inc(inc(inc(x)))

-- todo: lookout function for second task
lookout :: Int -> Int -> Bool
lookout x y = x > div y 10

-- todo: volume function for third task
volume :: Int -> Int -> Int
volume x y = x + y * mod x 12

-- ! type list
type CurrentDistrict = Int
type NextDistrict = Int
type HealthDamage = Int
type ArmorDamage = Int
type Health = Int
type Armor = Int
type Enhance = Int

-- todo: move function to move districts for fourth task
move :: (CurrentDistrict, NextDistrict) -> NextDistrict
move (x, y) = y

-- todo: attack function against beast for fifth task
arcaneMissiles :: (HealthDamage, ArmorDamage) -> (Health, Armor) -> (Health, Armor)
arcaneMissiles (hDam, aDam) (h, a) = (h - hDam, a - aDam)

-- todo: enhanced attack function against beast for sixth task
arcaneMissilesMark1 :: Enhance -> (HealthDamage, ArmorDamage) -> (Health, Armor) -> (Health, Armor)
arcaneMissilesMark1 enhance (hDam, aDam) (h, a) = (h - hDam * enhance, a - aDam *enhance)

-- todo: ultimate attack function against beast for seventh task
arcaneBlast :: (HealthDamage , ArmorDamage) -> (HealthDamage , ArmorDamage) -> (Health , Armor) -> (Health , Armor)
arcaneBlast  (hDam, aDam) (hDam1, aDam1) (h, a) = (h - (hDam * hDam1 + aDam * aDam1), a - (hDam * hDam1 + aDam * aDam1))



