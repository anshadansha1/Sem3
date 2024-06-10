<?php

use Illuminate\Support\Facades\Route;
use App\Http\Controllers\HomeController;

// Route::get('/', function () {
//     return view('welcome');
// });

Route::get('/',[HomeController::Class,'homepage']);
Route::get('/about-us',[HomeController::Class,'aboutus']);
Route::get('/contact-us',[HomeController::Class,'contact']);