@extends('app')

@section('content')
    <div>
        <ul>
            @foreach ($cart->getItems() as $item)
                <li>{{ $item->product()->nome }} - ${{ $item->prezzo }}</li>
            @endforeach
        </ul>
        <h2>Total: {{ $cart->totale }}</h2>
        <button type="submit">Checkout</button>
    </div>
@endsection