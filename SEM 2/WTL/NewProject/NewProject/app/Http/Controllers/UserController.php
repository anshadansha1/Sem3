<?php

namespace App\Http\Controllers;

use App\Models\User;
use Illuminate\Http\Request;

class UserController extends Controller
{
    function register(Request $request){
        $IncomingFields = $request->validate([
            'name'=>['required', 'min:4', 'max:20'],
            'email'=>'required',
            'password'=>['required', 'confirmed']
        ]);
        User::create($IncomingFields);
        return view('homepage');
    }
    function login(Request $request){
        $IncomingFields = $request->validate([
            'name'=>['required'],
            'password'=>['required']
        ]);
        if(auth()->attempt(['name'=>$IncomingFields['name'], 
            'password'=>$IncomingFields['password']
        ])){
            return view('profile');
        }
        else{
            return('Failed');
        }
    }
}
