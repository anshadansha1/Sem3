<?php

use Illuminate\Support\Facades\Route;
use App\Http\Controllers\HomeController;

// Route::get('/', function () {
//     return view('welcome');
// });

Route::get('/',[HomeController::Class,'homepage']);
Route::get('/about',[HomeController::Class,'aboutus']);
Route::get('/contact',[HomeController::Class,'contactus']);