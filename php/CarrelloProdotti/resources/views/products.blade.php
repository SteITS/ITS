@extends('app')

@section('content')
    <table>
        <thead>
            <tr>
                <th>Nome</th>
                <th>Categoria</th>
                <th>Prezzo</th>
                <th>Azioni</th>
            </tr>
        </thead>
        <tbody>
            @foreach ($prodotti as $prodotto)
                <tr>
                    <td>{{ $prodotto->nome }}</td>
                    <td>{{ $prodotto->categoria }}</td>
                    <td>{{ $prodotto->prezzo }}</td>
                    <td>
                        <form action="{{ route('carts.store') }}" method="post">
                            @csrf
                            <input type="hidden" name="prodotto_id" value="{{ $prodotto->id }}">

                            <button>Add Prodotto</button>

                        </form>
                    </td>
                </tr>
            @endforeach
        </tbody>
    </table>
@endsection