<?php

use App\Http\Controllers\CartController;
use App\Http\Controllers\ItemController;
use App\Http\Controllers\ProductController;
use App\Models\Item;
use Illuminate\Support\Facades\Route;

Route::get('/', function () {
    return view('app', ['titolo' => 'Benvenuto', 'home' => true]);
})->name('home');

Route::resource('products',ProductController::class);
Route::resource('carts',CartController::class);
Route::resource('items',ItemController::class);