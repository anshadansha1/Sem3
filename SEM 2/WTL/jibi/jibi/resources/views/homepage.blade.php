<x-layout>
<form action="register" method="POST">
    @csrf
<div class="form-group">
    @error ('uname')
    <p style='color:red;'>{{$message}}</p>
    @enderror
    <label for="uname">Username</label>
    <input type="text" class="form-control" id="uname" name="uname" aria-describedby="emailHelp" placeholder="Enter email">
  </div>
  <div class="form-group">
  @error ('email1')
    <p style='color:red;'>{{$message}}</p>
    @enderror
    <label for="email">Email address</label>
    <input type="email" class="form-control" id="email" name="email" aria-describedby="emailHelp" placeholder="Enter email">
    <small id="emailHelp" class="form-text text-muted">We'll never share your email with anyone else.</small>
  </div>
  <div class="form-group">
    <label for="pass">Password</label>
    <input type="password" class="form-control" id="pass" name="pass" placeholder="Password">
  </div>
  <div class="form-group">
    <label for="password_confirmation">Confirm Password</label>
    <input type="password" class="form-control" id="password_confirmation" name="password_confirmation" placeholder="Confirm Password">
  </div>
  <div class="form-check">
    <input type="checkbox" class="form-check-input" id="exampleCheck1">
    <label class="form-check-label" for="exampleCheck1">Check me out</label>
  </div>
  <button type="submit" class="btn btn-primary">Register</button>
</form>
</x-layout>