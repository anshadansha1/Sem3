<?php

namespace App\Http\Controllers;

use Illuminate\Http\Request;

class FirstController extends Controller
{
    //create a function
    function homepage(){
        // return '<h1>Home page</h1><br><a href="/about">Go to About page</a>';
        $names_array = ["Tommy","Tony"];
        return view("homepage",['name'=>$names_array]);
    }

    function about(){
        return '<h1>About page</h1><br><a href="/">Go to Home</a>';
    }
    function contact(){
        return '<h1>CONTACT page</h1><br><a href="/">Go to Home</a>';
    }
}
