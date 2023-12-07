
function lnko($szamlalo, $nevezo) {

    while ($nevezo -ne 0) {
        $temp = $nevezo
        $nevezo = $szamlalo % $nevezo
        $szamlalo = $temp
    }
    # prompt: lebontom a szamlalot a nevezovel, amig csak oszthato vele
    # prompt: az igy kapott szam az lnko
    return $szamlalo
}

$szamlalo = Read-Host "szamlalo"
$nevezo = Read-Host "nevezo"
# prompt: bekerek ket szamot --> szam, nem

$lnko = lnko $szamlalo $nevezo
# prompt: kiszamolom a ket szam lnkojat
$osztottSzaml = $szamlalo / $lnko
$osztottNev = $nevezo / $lnko
# prompt: egyszerusitek az lnvkoval

Write-Host "egyszerusitett tort: $osztottSzaml / $osztottNev"
# prompt: kiirom az igy kapott tortet
