<?php

use Illuminate\Support\Facades\Route;
use App\Http\Controllers\BlogsController;

Route::get('/', [BlogsController::class,'homepage']);

Route::get('/add1', [BlogsController::class,'add'])->name('add');
Route::post('/add1', [BlogsController::class,'addblogs'])->name('addblogs');

Route::get('/view1', [BlogsController::class,'viewblogs'])->name('view');

Route::get('blogs/{id}/delete', [BlogsController::class,'delblogs'])->name('del');

Route::get('blogs/{id}/edit', [BlogsController::class,'edit'])->name('edit');
Route::put('blogs/{id}/edit', [BlogsController::class,'editblogs'])->name('editblogs');