$matrix = @(
    @(1, 2, 3),
    @(4, 5, 6),
    @(7, 8, 9)
)
$m = New-Object 'object[,]' 4, 5
$m[2, 3] = "hello"
$m[1, 1] = 12

# prompt: two ways to create a matrix

# prompt: version 7
$t = [object[, ]]::new(3, 4)
