<?php

use Illuminate\Support\Facades\Route;
use App\Http\Controllers\FirstController;

Route::get('/', function () {
    return view('home');
});

Route::post('/login',[FirstController::Class,'loginfunction']);
Route::post('/register',[FirstController::Class,'registerfunction']);
