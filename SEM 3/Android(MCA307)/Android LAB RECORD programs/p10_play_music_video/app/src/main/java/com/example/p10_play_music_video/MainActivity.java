package com.example.p10_play_music_video;

import android.os.Bundle;

import androidx.activity.EdgeToEdge;
import androidx.appcompat.app.AppCompatActivity;
import androidx.core.graphics.Insets;
import androidx.core.view.ViewCompat;
import androidx.core.view.WindowInsetsCompat;

//import
import android.view.View;
import android.media.MediaPlayer;
import android.widget.MediaController;
import android.widget.VideoView;


public class MainActivity extends AppCompatActivity {
    MediaPlayer mediaPlayer;

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

    //Function For adding Audio
    public void PlayAudio(View view){
        if (mediaPlayer != null && mediaPlayer.isPlaying()) {
            mediaPlayer.stop();
            mediaPlayer.release();
        }
        MediaPlayer ring = MediaPlayer.create(MainActivity.this,R.raw.audio);
        ring.start();
    }

    //Function For Adding Video
    public void PlayVideo(View view){

        //Create a Reference object for VideoView
        VideoView videoview = findViewById(R.id.videoView);
        //Set Path for Video to be used in VideoView
        videoview.setVideoPath("android.resource://"+getPackageName()+"/"+R.raw.video);
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