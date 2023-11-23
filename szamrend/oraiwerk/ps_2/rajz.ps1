param($a_oldal, $b_oldal)

for ($i = 0; $i -lt $a_oldal; $i++) {
    "*".PadLeft($b_oldal, "*")
    # prompt: padleft: load from left with second parameter first parameter times
}

$t = $a_oldal * $b_oldal
Write-Host "terület:" $t
