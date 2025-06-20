<?php

namespace App\Models;

use Illuminate\Database\Eloquent\Model;

class Item extends Model
{
    protected $fillable = [
        'product_id',
        'prezzo',
    ];

    public function product()
    {
        return Product::find($this->product_id);
    }

}
