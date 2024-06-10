<?php

namespace App\Http\Controllers;

use App\Models\User;
use Illuminate\Http\Request;

class HomeController extends Controller
{
    function homepage(){
        $name = 'anshad';
        $age = 30;
        $users = User::all();
        return $users;
        return view('welcome',compact('name','age'));
    }
    function aboutus(){
        return view('about-us');
    }
    function contact(){
        return view('contact-us');
    }
}
