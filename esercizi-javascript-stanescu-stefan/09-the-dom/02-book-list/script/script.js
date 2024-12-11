// Array of books with added 'url' property for cover images
let books = [
    {
        title: 'The Design of EveryDay Things',
        author: 'Don Norman',
        alreadyRead: false,
        url: 'https://m.media-amazon.com/images/I/61QICOkQ5sL._AC_UF1000,1000_QL80_.jpg'
    },
    {
        title: 'The Most Human Human',
        author: 'Brian Christian',
        alreadyRead: false,
        url: 'https://m.media-amazon.com/images/I/51K8nFCAeML._AC_UF1000,1000_QL80_.jpg'
    },
    {
        title: 'Clean Code',
        author: 'Robert C. Martin',
        alreadyRead: true,
        url: 'https://m.media-amazon.com/images/I/51E2055ZGUL.jpg'
    },
    {
        title: 'Spice and Wolf, Vol. 1 (light novel)',
        author: 'Isuna Hasekura',
        alreadyRead:true,
        url: 'https://m.media-amazon.com/images/I/91NSp1vfDqL._UF1000,1000_QL80_.jpg'
    }
];


const bookList = document.getElementById('book-list');

books.forEach((book) => {
    const li = document.createElement('li');

    const bookDetails = document.createElement('p');
    bookDetails.textContent = `${book.title} by ${book.author}`;

    const img = document.createElement('img');
    img.src = book.url;
    img.alt = `${book.title} cover`;

    li.appendChild(bookDetails);
    li.appendChild(img);

    if (book.alreadyRead) {
        li.style.color = 'green';
        li.style.fontWeight = 'bold';
    } else {
        li.style.color = 'red';
    }

    bookList.appendChild(li);
});

// Add an external CSS file after 5 seconds
setTimeout(() => {
    const link = document.createElement('link');
    link.rel = 'stylesheet';
    link.href = './style/style.css';
    document.head.appendChild(link);
}, 5000);
