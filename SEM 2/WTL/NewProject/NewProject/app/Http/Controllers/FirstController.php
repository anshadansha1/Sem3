<?php

namespace App\Http\Controllers;

use Illuminate\Http\Request;

class FirstController extends Controller
{
    
    function homepage(){
        $names = ["Tommy", "Tony"];
        return view('homepage', ['name'=>$names]);
    }
    function about(){
        return view('about');
    }
}
