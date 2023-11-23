$a = New-Object 'object[,]' 22, 22
$b = New-Object 'object[,]' 22, 22

function kezdes {
    for ($i = 0; $i -lt 22; $i++) {
        for ($j = 0; $j -lt 22; $j++) {
            $a[$i, $j] = 0
            $b[$i, $j] = 0
        }
    }
    # prompt: filling the two matrices with 0

    $a[10, 10] = 1
    $a[10, 11] = 1
    
}

function rajz {
    Clear-Host
    for ($i = 1; $i -lt 21; $i++) {
        for ($j = 1; $j -lt 21; $j++) {
            if ($a[$i, $j] -eq 1) {
                Write-Host -NoNewline "#"
            }
            else {
                Write-Host -NoNewline " "
            }
        }
        Write-Host
    }
    # prompt: drawing the matrix
}

function masol {
    for ($i = 1; $i -lt 21; $i++) {
        for ($j = 1; $j -lt 21; $j++) {
            $a[$i, $j] = $b[$i, $j]
        }
    }
    # prompt: copying the matrix
}

function szomszed {
    param($x, $y)
    $s = 0
    for ($i = $x - 1; $i -le $x + 1; $i++) {
        for ($j = $y - 1; $j -le $y + 1; $j++) {
            $s += $a[$i, $j]
        }
    }
    $s -= $a[$x, $y]

    return $s

    # prompt: counting the neighbours of the element at position x, y
}

function lepes {
    for ($i = 1; $i -lt 21; $i++) {
        for ($j = 1; $j -lt 21; $j++) {
            $a[$i, $j] = $b[$i, $j]
            $sz = szomszed $i $j
            switch ($sz) {
                0 { $b[$i, $j] = $a[$i, $j]; break }
                1 { $b[$i, $j] = 1; break }
                2 { $b[$i, $j] = 1; break }
                3 { $b[$i, $j] = $a[$i, $j]; break }
                4 { $b[$i, $j] = $a[$i, $j]; break }
                5 { $b[$i, $j] = 1; break }
                6 { $b[$i, $j] = 1; break }
                7 { $b[$i, $j] = 0; break }
                8 { $b[$i, $j] = $a[$i, $j]; break }
            }
        }
    }
}

kezdes

for ($k = 0; $k -lt 10; $k++) {
    rajz
    lepes
    masol
    sleep(0.2)

}