<?php

namespace App\Models;

use Illuminate\Database\Eloquent\Model;

class Cart extends Model
{
    protected $items = [];
    protected $fillable = [
        'totale'
    ];


    public function addItem(Item $item)
    {
        $this->items[] = $item;
        $this->totale += $item->prezzo;
    }

    public function getItems()
    {
        return $this->items;
    }

    public function items()
    {
        return $this->hasMany(Item::class);
    }
}
