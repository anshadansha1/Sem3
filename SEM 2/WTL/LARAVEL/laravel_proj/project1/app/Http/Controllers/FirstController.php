<?php

namespace App\Http\Controllers;

use Illuminate\Http\Request;

class FirstController extends Controller
{
    function loginfunction(){
        return view('login');
    }
    function registerfunction(){
        return view('register');
    }
}
