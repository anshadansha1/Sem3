<?php

use Illuminate\Support\Facades\Route;
use App\Http\Controllers\UserController;
use App\Http\Controllers\FirstController;

Route::get('/', [FirstController::class, 'homepage']);
Route::get('/about', [FirstController::class, 'about']);
Route::post('/register', [UserController::class, 'register']);
Route::post('/login', [UserController::class, 'login']);