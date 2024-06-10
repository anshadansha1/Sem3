<?php

namespace App\Http\Controllers;

use App\Models\User;
use Illuminate\Http\Request;

class HomeController extends Controller
{
    function homepage(){
        $name = 'anshad';
        $age = 30;

        $users = User::all(); //select * from users
        $user = User::find(43);
        // $user = User::where('id','=',43)->get();
        // $user = User::where('email','=','porter72@example.com')->get();
        // $users = User::whereIn('id',[43,23])->get();

        // return $user[0]->name;
        return $user->email_verified_at->format('d-M-Y');
        // return $users;
        return view('welcome',compact('name','age'));
    }
    function aboutus(){
        return view('about-us');
    }
    function contactus(){
        return view('contact-us');
    }
}
