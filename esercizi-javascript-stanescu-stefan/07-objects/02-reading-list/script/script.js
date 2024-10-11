/**
 * @file: script.js
 * @author: Stefan Stanescu
 * 
 * Logs the books in the object, tells if it's already read or not
 */

const books = [
    {
        title: "The Hobbit",
        author: "J.R.R. Tolkien",
        alreadyRead: true
    },
    {
        title: "1984",
        author: "George Orwell",
        alreadyRead: false
    },
    {
        title: "Spice & Wolf Vol.1",
        author: "Isuna Hasekura",
        alreadyRead: false
    }
];

books.forEach(book => {

    const{title, author, alreadyRead} = book;

    console.log(`${title} by ${author}`)

    if (alreadyRead){
        console.log(`You already read "${title}" by ${author}`)
    }else{
        console.log(`You still need to read "${title}" by ${author}`)
    }
});