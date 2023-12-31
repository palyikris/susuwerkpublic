import Control.Exception
import System.IO.Unsafe
import Data.List

-- todo: create own type called Time for Task 1
data Time = T Int Int deriving Eq

-- todo: create smart constructor for Task 2
t :: Int -> Int -> Time
t h min
    | h >= 0 && h <= 23 && min >= 0 && min <= 59 = T h min
    -- prompt: check if h in [0..23] and min in [0..59], all inclusive
    | otherwise = error "Time given is out of range!"
    -- prompt: otherwise throw back error

-- todo: create function that displays time (hh:mm) for Task 3
showTime :: Time -> String
showTime (T h min) = show h ++ ":" ++ show min

-- todo: function to decide which is earlier for Task 4
isEarlier :: Time -> Time -> Bool
isEarlier (T h min) (T h' min') = h < h' || (h == h' && min < min')
-- prompt: if h is less than h' --> will always be true --> ||
-- prompt: if its not then if its greater result should always be false --> (h == h' &&)
-- prompt: if two hs equal then if min smaller --> true otherwise --> false

-- todo: function to decide if middle time is between the other two for Task 5
isBetween :: Time -> Time -> Time -> Bool
isBetween t1 t2 t3 = isEarlier t1 t2 && isEarlier t2 t3 || isEarlier t3 t2 && isEarlier t2 t1
-- prompt: used isEarlier for two cases --> t1<t2<t3 or t3<t2<t1

-- todo: define new type called USTime for Task 6
data AMPM = AM | PM deriving Eq
data USTime = UST AMPM Int Int deriving Eq
-- prompt: created type to store if am or pm

-- todo: create another smart constructor for Task 7
ustime :: AMPM -> Int -> Int -> USTime
ustime ampm h min
    | h >= 0 && h <= 12 && min >= 0 && min <= 59 = UST ampm h min
    -- prompt: check if h in [0..12] and min in [0..59], all inclusive
    | otherwise = error "Time given is out of range!"
    -- prompt: otherwise throw back error

-- todo: display ustime for Task 8
-- prompt: first had to create function to show ampm
showAMPM :: AMPM -> String
showAMPM AM = "AM"
showAMPM PM = "PM"

showUSTime :: USTime -> String
showUSTime (UST ampm h min) = (showAMPM ampm) ++ " " ++ show h ++ ":" ++ show min
-- prompt: create format AM/PM H M

-- todo: convert ust to t for Task 9
ustimeToTime :: USTime -> Time
ustimeToTime (UST ampm h min)
    | ampm == AM = helper h min
    | h == 12 = t h min
    -- prompt: if hour is 12 and pm return unchanged
    -- example: PM 12:30 --> 12:30
    | otherwise = t (h+12) min
    -- prompt: if pm the hour just needs +12
    -- example: PM 11:30 --> 23:30
        where 
            helper h min
                | h == 12 = t 0 min
                -- prompt: if its am and hour is 12 hour will be 0
                -- example: AM 12:20 --> 0:20
                | otherwise = t h min
                -- prompt: otherwise return hour and minute
                -- example: AM 11:30 --> 11:30


-- todo: convert t to ust for Task 10
timeToUSTime :: Time -> USTime
timeToUSTime (T 0 min) = ustime AM 12 min
-- prompt: if hour is 0 it needs to be an AM 12
-- example: 0:10 --> AM 12:10
timeToUSTime (T h min)
    | h < 12 = ustime AM h min
    -- prompt: if hour is less than 12, return unchanged
    -- example: 11:20 --> AM 11:20
    | h == 12 = ustime PM h min
    -- prompt: if hour is 12 return it but pm
    -- example: 12:12 --> PM 12:12
    | otherwise = ustime PM (h-12) min
    -- prompt: otherwise need to subtract 12 from hour
    -- example: 14:10 --> PM 2:10







