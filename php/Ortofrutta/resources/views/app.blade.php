<!DOCTYPE html>
<html lang="en">

<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <meta http-equiv="X-UA-Compatible" content="ie=edge">
    <title>Document</title>
    <link rel="stylesheet" href="https://cdn.jsdelivr.net/npm/@picocss/pico@2/css/pico.min.css">
</head>

<body>
    <div class="container">
        <nav>
            <ul>
                <li><a href="{{ Route('home') }}">Home</a></li>
                <li><a href="{{ Route('prodotti') }}">PRODOTTI</a></li>
            </ul>
        </nav>
        @yield('content')
    </div>
</body>

</html>