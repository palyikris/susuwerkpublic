function fakt {
    param([int]$szam = $(throw "add an integer"))
    if ($szam -lt 0) {
        throw "add a positive integer"
    }
    $result = 1
    for ($i = 1; $i -le $num; $i++) {
        $result *= $i
    }

    Write-Host $result
}

fakt 6