const numbers = [5, 2, 15, -3, 6, -8, -2];

const matrix = [[1, 0, 3], [0, 2, 0], [4, 5, 6], [0, 0, 0]];

const searchResults = {
  Search: [
    {
      Title: "The Hobbit: An Unexpected Journey",
      Year: "2012",
      imdbID: "tt0903624",
      Type: "movie"
    },
    {
      Title: "The Hobbit: The Desolation of Smaug",
      Year: "2013",
      imdbID: "tt1170358",
      Type: "movie"
    },
    {
      Title: "The Hobbit: The Battle of the Five Armies",
      Year: "2014",
      imdbID: "tt2310332",
      Type: "movie"
    },
    {
      Title: "The Hobbit",
      Year: "1977",
      imdbID: "tt0077687",
      Type: "movie"
    },
    {
      Title: "Lego the Hobbit: The Video Game",
      Year: "2014",
      imdbID: "tt3584562",
      Type: "game"
    },
    {
      Title: "The Hobbit",
      Year: "1966",
      imdbID: "tt1686804",
      Type: "movie"
    },
    {
      Title: "The Hobbit",
      Year: "2003",
      imdbID: "tt0395578",
      Type: "game"
    },
    {
      Title: "A Day in the Life of a Hobbit",
      Year: "2002",
      imdbID: "tt0473467",
      Type: "movie"
    },
    {
      Title: "The Hobbit: An Unexpected Journey - The Company of Thorin",
      Year: "2013",
      imdbID: "tt3345514",
      Type: "movie"
    },
    {
      Title: "The Hobbit: The Swedolation of Smaug",
      Year: "2014",
      imdbID: "tt4171362",
      Type: "movie"
    }
  ],
  totalResults: "51",
  Response: "True"
};

// 1.
console.log("1. feladat");
const squares = numbers.map(num => num * num);
console.log(squares);

// 2.
console.log("2. feladat");
const minNumber = numbers.reduce(
  (min, num) => (num < min ? num : min),
  numbers[0]
);
console.log(minNumber);

// 3.
console.log("3. feladat");
const onlyZero = matrix.map(row => row.every(num => num === 0));
const indexOfZero = onlyZero.indexOf(true);
console.log(indexOfZero);

// 4.
console.log("4. feladat");
const filteredMovies = searchResults.Search
  .filter(result => result.Type === "movie" && parseInt(result.Year) > 2010)
  .map(result => result.imdbID);
console.log(filteredMovies);
