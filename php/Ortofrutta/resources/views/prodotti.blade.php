@extends('app')
@section('content')

    <h1>Prodotti</h1>

    <body>
        <div class="container">
            <table>
                <thead>
                    <tr>
                        <th>Nome</th>
                        <th>Categoria</th>
                        <th>Origine</th>
                        <th>Prezzo</th>
                    </tr>
                </thead>
                <tbody>
                    @foreach ($prodotti as $p)
                        <tr>
                            <td>{{$p->nome}}</td>
                            <td>{{$p->categoria}}</td>
                            <td>{{$p->origine}}</td>
                            <td>{{$p->prezzo_kg}}</td>
                        </tr>
                    @endforeach
                </tbody>
            </table>

@endsection