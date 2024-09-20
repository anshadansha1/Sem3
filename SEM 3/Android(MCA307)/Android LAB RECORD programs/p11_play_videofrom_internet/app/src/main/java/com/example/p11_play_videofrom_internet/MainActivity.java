package com.example.p11_play_videofrom_internet;

import android.os.Bundle;

import androidx.activity.EdgeToEdge;
import androidx.appcompat.app.AppCompatActivity;
import androidx.core.graphics.Insets;
import androidx.core.view.ViewCompat;
import androidx.core.view.WindowInsetsCompat;


//import
import android.view.View;
import android.net.Uri;
import android.widget.MediaController;
import android.widget.VideoView;

public class MainActivity extends AppCompatActivity {

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        EdgeToEdge.enable(this);
        setContentView(R.layout.activity_main);
        ViewCompat.setOnApplyWindowInsetsListener(findViewById(R.id.main), (v, insets) -> {
            Insets systemBars = insets.getInsets(WindowInsetsCompat.Type.systemBars());
            v.setPadding(systemBars.left, systemBars.top, systemBars.right, systemBars.bottom);
            return insets;
        });
    }
    //Function For Adding Video
    public void PlayVideo(View view){

        //Create a Reference object for VideoView
        VideoView videoview = findViewById(R.id.videoView);
        //Set URL for Video to be used in VideoView
        String videoUrl ="https://cdn.pixabay.com/video/2016/04/02/2637-161442811_medium.mp4";
        //URI object to refer the resource from the videoUrl
        Uri uri = Uri.parse(videoUrl);
        //Sets the resource from the videoUrl to the videoview
        videoview.setVideoURI(uri);
        //Create Object for Media Controller
        MediaController mediaController = new MediaController(this);
        //Set Anchor View for videoview
        mediaController.setAnchorView(videoview);
        //Set mediaPlayer to videoview
        mediaController.setMediaPlayer(videoview);
        //Set Media controller for videoview
        videoview.setMediaController(mediaController);
        //Starts the video
        videoview.start();


    }
}