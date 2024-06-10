<x-layout>
    
    <form action="register" method="POST">
      @csrf
        <div class="form-group">
          @error('name')
          <p><font color="red">{{$message}}</font></p>
          @enderror
            <label for="exampleInputEmail1">Username</label>
            <input value="{{old('name')}}" name="name" type="text" class="form-control" id="exampleInputEmail1" aria-describedby="emailHelp" placeholder="Username">
            <small id="emailHelp" class="form-text text-muted">We'll never share your email with anyone else.</small>
          </div>
        <div class="form-group">
          @error('email')
          <p><font color="red">{{$message}}</font></p>
          @enderror
          <label for="exampleInputEmail1">Email address</label>
          <input value="{{old('email')}}" name="email" type="email" class="form-control" id="exampleInputEmail1" aria-describedby="emailHelp" placeholder="Enter email">
          <small id="emailHelp" class="form-text text-muted">We'll never share your email with anyone else.</small>
        </div>
        <div class="form-group">
          @error('password')
          <p><font color="red">{{$message}}</font></p>
          @enderror
          <label for="exampleInputPassword1">Password</label>
          <input name="password" type="password" class="form-control" id="exampleInputPassword1" placeholder="Password">
        </div>
        <div class="form-group">
          @error('password_confirmation')
          <p><font color="red">{{$message}}</font></p>
          @enderror
          <label for="exampleInputPassword1">Retype password</label>
          <input name="password_confirmation" type="password" class="form-control" id="exampleInputPassword1" placeholder="Password">
        </div>
        <button type="submit" class="btn btn-primary">Sign up</button>
      </form>

      <form action="login" method="POST">
        @csrf
          <div class="form-group">
            @error('name')
            <p><font color="red">{{$message}}</font></p>
            @enderror
              <label for="exampleInputEmail1">Username</label>
              <input value="{{old('name')}}" name="name" type="text" class="form-control" id="exampleInputEmail1" aria-describedby="emailHelp" placeholder="Username">
              <small id="emailHelp" class="form-text text-muted">We'll never share your email with anyone else.</small>
            </div>
            <div class="form-group">
              @error('password')
              <p><font color="red">{{$message}}</font></p>
              @enderror
              <label for="exampleInputPassword1">Password</label>
              <input name="password" type="password" class="form-control" id="exampleInputPassword1" placeholder="Password">
            </div>
            <button type="submit" class="btn btn-primary">Sign in</button>
          </form>
</x-layout>