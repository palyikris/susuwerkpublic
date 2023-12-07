
param (
    [int]$a,
    [int]$b
)
# prompt: ket int parameter: magassag, szelesseg

    
for ($i = 0; $i -lt $a; $i++) {
    for ($j = 0; $j -lt $b; $j++) {
        # prompt: csak akkor kell +-t irni, ha elso sor, utso sor
        # prompt: vagy a sorban az elso v utso
        if (($i -eq 0) -or ($i -eq $a - 1) -or ($j -eq 0) -or ($j -eq $b - 1)) {
            Write-Host -NoNewline "+"
        }
        # prompt: kulonben egy sima space kell csak
        else {
            Write-Host -NoNewline " "
        }
    }
    Write-Host ""
    # prompt: sortoresnek egy sor utan
}



$terulet = $a * $b
$kerulet = 2 * ($a + $b)
# prompt: kepletekkel kiszamolom amit kell

Write-Host "terület: $terulet, kerület: $kerulet"

