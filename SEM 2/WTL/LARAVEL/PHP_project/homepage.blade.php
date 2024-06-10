
<x-layout>
    <h1>Home Page <?php echo "Hello php"?></h1>
    <!-- <p>Hellooo</p>
    <a href="/about">About page</a>
    
    <h1>Array listing <br> @foreach ($name as $i)
            {{$i}}
        @endforeach
    </h1>
    <br>
    <hr> -->



  <form action="register.php" method="POST">
  <div class="mb-3">
    <label for="exampleInputEmail1" class="form-label">Email address</label>
    <input type="email" class="form-control" id="exampleInputEmail1" aria-describedby="emailHelp">
    <div id="emailHelp" class="form-text">We'll never share your email with anyone else.</div>
  </div>
  <div class="mb-3">
    <label for="exampleInputEmail1" class="form-label">Username </label>
    <input type="text" class="form-control" id="exampleusername" aria-describedby="usernameHelp">
    <div id="emailHelp" class="form-text">We'll never share your username with anyone else.</div>
  </div>
  <div class="mb-3">
    <label for="exampleInputPassword1" class="form-label">Password</label>
    <input type="password" class="form-control" id="exampleInputPassword1">
  </div>
  <div class="mb-3 form-check">
    <input type="checkbox" class="form-check-input" id="exampleCheck1">
    <label class="form-check-label" for="exampleCheck1">Check me out</label>
  </div>
  <button type="submit" class="btn btn-primary">Submit</button>
</form>

</x-layout>



