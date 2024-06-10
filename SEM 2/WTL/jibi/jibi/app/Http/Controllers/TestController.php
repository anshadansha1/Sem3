<?php

namespace App\Http\Controllers;

use App\Models\User;
use Illuminate\Http\Request;

class TestController extends Controller
{
    function register(Request $request){
        $IncomingFields = $request->validate([
            'uname'=>['required'],
            'email'=>['required'],
            'pass'=>['required','confirmed'],
        ]);
        User::create($IncomingFields);
        return view('homepage');
    }

    function login(Request $request){
        $IncomingFields = $request->validate([
            'uname'=>['required'],
            'pass'=>['required'],
        ]);
        if(auth()->attempt([
            'uname' => $IncomingFields['uname'],
            'pass' => $IncomingFields['pass']   
        ]))
        {
            return view('homepage');}
        else{
            return ('Failed');
        }
        
    }
}
