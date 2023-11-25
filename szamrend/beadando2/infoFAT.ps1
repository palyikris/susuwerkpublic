param (
    [switch]$lista,
    [switch]$szabad,
    [switch]$max,
    [int]$foglal
)

$FATFile = "FAT.dat"

if ($lista) {
    Get-Content $FATFile
    # prompt: simply print the content of the file
}

$content = Get-Content $FATFile -Raw
# prompt: get the contents of the file as a single string

if ($szabad) {
    $freeBlocks = 0
    # prompt: make a var for the number of free blocks
    for ($i = 0; $i -lt $content.Length; $i++) {
        if ($content[$i] -eq "S") {
            # prompt: if the curr block is S, add one to the free blocks
            $freeBlocks++
        }
    }
    Write-Output "Szabad blokkok szama: $freeBlocks"
}

function MaxFreeBlocksInRow() {
    $freeBlocksInRow = 0
    $maxFreeBlocksInRow = 0

    for ($i = 0; $i -lt $content.Length; $i++) {
        if ($content[$i] -eq "S") {
            # prompt: if the curr block is S, add one to the free blocks in row
            $freeBlocksInRow++
            if ($freeBlocksInRow -gt $maxFreeBlocksInRow) {
                # prompt: if the curr free blocks > max free blocks --> update max free blocks
                $maxFreeBlocksInRow = $freeBlocksInRow
            }
        }
        else {
            $freeBlocksInRow = 0
            # prompt: if the curr block is not S, reset the free blocks in row
        }
    }

    return $maxFreeBlocksInRow
}

if ($max) {
    $maxFreeBlocksInRow = MaxFreeBlocksInRow
    # prompt: calling MaxFreeBlocksInRow and storing the result in a var
    Write-Output "Leghosszabb egy sorban levo szabad blokkok szama: $maxFreeBlocksInRow"
}

if ($foglal) {
    $maxFreeBlocksInRow = MaxFreeBlocksInRow
    # prompt: calling MaxFreeBlocksInRow and storing the result in a var
    if ($foglal -le $maxFreeBlocksInRow) {
        $newContent = $content -replace ("S" * $foglal), ("F" * $foglal)
        # prompt: if the n of blocks valid --> replace the first n*S with n*F
        $newContent | Set-Content $FATFile
        # prompt: new content to the file
        Write-Output "$foglal blokk lefoglalva."
    }
    else {
        # prompt: if the n of blocks invalid --> error msg
        Write-Output "Nincs eleg szabad blokk."
    }
}


