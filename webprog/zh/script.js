matrix = [[1, 2, 3], [2, 0, 5], [0, 1, 2]];
matrix = matrix.map(row => row.indexOf(0) !== -1);
console.log("1. feladat");
console.log(matrix.filter(row => row).length);

nums = [8, 18, 5, 91, 7];
function isPrime(num) {
  divs = [];
  i = 0;
  while (i <= num) {
    if (num % i === 0) {
      divs.push(i);
    }
    i += 1;
  }
  return divs.length === 2;
}
console.log(nums.filter(num => isPrime(num)).length);
