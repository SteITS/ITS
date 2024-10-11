/**
 * @file: script.js
 * @author: Stefan Stanescu
 * 
 * From an array object 'movies' logs all of the details of
 * each movie or just a single one
 */

const movies = [
    {
        title: "Puff the Magic Dragon",
        duration: 30, 
        stars: ["Puff", "Jackie", "Living Sneezes"]
    },
    {
        title: "The Matrix",
        duration: 136,
        stars:  ["Keanu Reeves", "Laurence Fishburne", "Carrie-Anne Moss"]
    },
    {
        title: "John Wick",
        duration: 101,
        stars: ["Keanu Reeves", "Michael Nyqvist", "Alfie Allen"]
    }
];

function printMovie(movie){
    const starsst = movie.stars.join(", ");
    console.log(`${movie.title}, duration: ${movie.duration}, stars: ${starsst}`);
}

printMovie(movies[2]);

console.log('\nAll Movies:');
movies.forEach(printMovie);