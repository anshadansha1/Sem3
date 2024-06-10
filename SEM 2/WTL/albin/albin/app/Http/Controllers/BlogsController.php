<?php

namespace App\Http\Controllers;

use App\Models\Blogs;
use Illuminate\Http\Request;

class BlogsController extends Controller
{
    public function homepage(){
        return view('blogs.home');
    }
    public function add(){
        return view('blogs.add');
    }
    public function addblogs(Request $request){

        $request->validate([
            'title'=> 'required',
            'content' => 'required',
        ]);

        Blogs::create([
            'title' => $request->title, 
            'content' => $request->content,
        ]);
        return redirect('view1')->with('Success','Blog added successfully');
    }

    public function viewblogs(){
        $data = Blogs::all();
        return view('blogs.view',compact('data'));
    }

    public function delblogs(int $id){
        $request = Blogs:: findOrFail($id);
        $request->delete();
        return redirect('view1')->with('success','Blogs deleted successfully');
    }

    public function  edit(int $id){
        $blogs = Blogs::findOrFail($id);
        return view('blogs.edit',compact('blogs'));

    }

    public function editblogs(Request $request,int $id){
        $request->validate([
            'title' => 'required',
            'content' => 'required'
        ]);

        $blogs = Blogs::findOrFail($id);
        $blogs->update([
            'title' =>$request->title,
            'content' => $request->content
        ]);
        return redirect('view1')->with('Success','Blogs updated successfully');
    }
}
