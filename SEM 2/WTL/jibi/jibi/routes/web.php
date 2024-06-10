<?php

use Illuminate\Support\Facades\Route;
use App\Http\Controllers\TestController;
use App\Http\Controllers\UserController;

Route::get('/',[UserController::Class,'homepage']);
Route::post('/register',[TestController::Class,'register']);
Route::get('/login',[UserController::Class,'loginpage']);
Route::post('/login',[TestController::Class,'loginpage']);