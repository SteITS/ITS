<!DOCTYPE html>
<html lang="en">

<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <meta http-equiv="X-UA-Compatible" content="ie=edge">
    <title>Carrello Prodotti</title>
    <link rel="stylesheet" href="https://cdn.jsdelivr.net/npm/@picocss/pico@2/css/pico.min.css">
</head>

<body>
    <div class="container">
        <nav>
            <ul>
                <li><a href="{{ route('home') }}">Home</a></li>
                <li><a href="{{ route('products.index') }}">Aggiungi Prodotto</a></li>
                <li><a href="{{ route('carts.index') }}">Carrello</a></li>
                <li><a href="{{ route('items.index') }}">Items</a></li>
            </ul>
        </nav>
        <h1>{{ $titolo }}</h1>
        @if ($home)
            <p>
                Lorem ipsum dolor sit amet consectetur, adipisicing elit. Perferendis aperiam quia optio veniam officiis
                odit
                sapiente in aspernatur nesciunt dolorum unde corporis laudantium, laboriosam voluptates at consequatur quasi
                asperiores maiores!
            </p>
        @endif
        @yield('content')
    </div>
</body>

</html>