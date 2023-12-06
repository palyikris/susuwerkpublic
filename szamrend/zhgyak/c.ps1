param (
    [string]$Path = (Get-Location).Path
)

if (-not (Test-Path -Path $Path)) {
    Write-Host "The specified path does not exist."
    return
}

$Folders = Get-ChildItem -Path $Path -Directory

foreach ($Folder in $Folders) {
    Write-Host "Folder: $($Folder.Name)"
    $Files = Get-ChildItem -Path $Folder.FullName -File
    foreach ($File in $Files) {
        Write-Host "  $($File.Name)"
    }
}
