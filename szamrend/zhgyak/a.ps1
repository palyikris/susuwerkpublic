
$lines = @()

do {
    $line = Read-Host "Irj be targyakat (nev kredit jegy))"
    if ($line -ne "") {
        $lines += $line
    }
} while ($line -ne "")


function addProducts {
    
    $sum = 0
    foreach ($line in $lines) {
        $splitLine = $line.Split(" ")
        if ($splitLine[2] -eq "0") {
            $sum += 0
        }
        if ($splitLine[2] -eq "1") {
            $sum += 0
        }
        else {
            $sum += [int]$splitLine[2] * [int]$splitLine[1]
        }
    }
    
    return $sum
}


$sum = addProducts


$index = $sum / 30
Write-Host "A kreditindexed $index"
