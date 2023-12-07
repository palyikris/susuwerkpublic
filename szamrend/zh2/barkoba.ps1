$gondoltSzam = Get-Random -Minimum 1 -Maximum 100
# prompt: random szam --> ezt kell kitalalni

$talalat = $false
# prompt: csekkolja hogy eltalaltak e szamot

while (-not $talalat) {
    $tipp = Read-Host "tipp"   
    
    Write-Host "amit tippeltel az..."
    if ($tipp -eq $gondoltSzam) {
        Write-Host "helyes!"
        $talalat = $true
    }
    elseif ($tipp -lt $gondoltSzam) {
        Write-Host "kisebb, mint amire gondoltam!"
    }
    else {
        Write-Host "nagyobb, mint amire gondoltam!"
    }
    # prompt: amig a szam nincs eltalalva, addig bekerek tippeket
    # prompt: kiirom, hogy kisebb, nagyobb v helyes a tipp
}