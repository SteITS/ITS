<?php

use App\Http\Controllers\ProductController;
use App\Models\Product;
use Illuminate\Support\Facades\Route;

Route::get('/', function () {
    return view('home');
})->name('home');
Route::get('/prodotti', [ProductController::class,'index'])->name('prodotti')->middleware(('auth'));

Route::get('/api/prodotti',function() {
    return Product::all();
});