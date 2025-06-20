<?php

namespace App\Http\Controllers;

use App\Models\Cart;
use App\Models\Item;
use App\Models\Product;
use Illuminate\Http\Request;

class CartController extends Controller
{
    /**
     * Display a listing of the resource.
     */
    public function index()
    {
        // session()->invalidate(); // REMOVE THIS LINE
        $cart = session()->get('cart', null);

        // If cart is not set, create a new Cart object
        if (!$cart) {
            $cart = new Cart(['totale' => 0]);
            session()->put('cart', $cart);
        }

        $titolo = 'Elenco Carrello';
        $home = false;
        return view('carts', compact('cart', 'titolo', 'home'));
    }

    /**
     * Show the form for creating a new resource.
     */
    public function create()
    {
        //
    }

    /**
     * Store a newly created resource in storage.
     */
    public function store(Request $request)
    {
        $product_id = $request->input(('prodotto_id'));
        $prodotto = Product::find($product_id);

        if(!session()->has('cart')){
            session()->put('cart', Cart::create([
                'totale' => 0,
            ]));
        }
        $carrello = session()->get('cart');
        $carrello->addItem(Item::create([
            'product_id' => $prodotto->id,
            'prezzo' => $prodotto->prezzo,
        ]));

        return redirect()->route('carts.index')->with('success', 'Prodotto aggiunto al carrello');
    }

    /**
     * Display the specified resource.
     */
    public function show(Cart $cart)
    {
        //
    }

    /**
     * Show the form for editing the specified resource.
     */
    public function edit(Cart $cart)
    {
        //
    }

    /**
     * Update the specified resource in storage.
     */
    public function update(Request $request, Cart $cart)
    {
        //
    }

    /**
     * Remove the specified resource from storage.
     */
    public function destroy($cart_id)
    {
        session()->forget('cart');
        Cart::destroy($cart_id);
        return redirect()->route('carts.index');
    }
}
