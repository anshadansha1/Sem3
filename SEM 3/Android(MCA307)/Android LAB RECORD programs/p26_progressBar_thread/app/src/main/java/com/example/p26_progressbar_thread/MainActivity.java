package com.example.p26_progressbar_thread;

import android.os.Bundle;


import androidx.activity.EdgeToEdge;
import androidx.appcompat.app.AppCompatActivity;
import androidx.core.graphics.Insets;
import androidx.core.view.ViewCompat;
import androidx.core.view.WindowInsetsCompat;

//import
import android.os.Handler;
import android.view.View;
import android.widget.Button;
import android.widget.ProgressBar;
import android.widget.TextView;
public class MainActivity extends AppCompatActivity {

    //Declaration
    private ProgressBar progressBar;
    private TextView textViewProgress;
    private Button buttonStartProgress;
    private int progressStatus = 0;
    private Handler handler = new Handler();// Used to update the UI from a background thread

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        EdgeToEdge.enable(this);
        setContentView(R.layout.activity_main);

        //Initialize
        progressBar = findViewById(R.id.progBar);
        textViewProgress = findViewById(R.id.tvProgress);
        buttonStartProgress = findViewById(R.id.buttonProgress);

        buttonStartProgress.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                //Step 1: Make progress bar visible
                progressBar.setVisibility(View.VISIBLE);

                //Step 2 :  Start a new thread to simulate the progress
                new Thread(new Runnable() {
                    @Override
                    public void run() {
                        while(progressStatus < 100){
                            progressStatus += 1;

                            //2.1: Sleep the thread to simulate work (e.g., downloading)
                            try{
                                Thread.sleep(100); // Adjust the sleep time to change the progress speed
                            }
                            catch(InterruptedException e){
                                e.printStackTrace();
                            }

                            //2.2 Update the progress bar and the TextView on the UI thread
                            handler.post(new Runnable() {
                                @Override
                                public void run() {
                                    progressBar.setProgress(progressStatus);
                                    textViewProgress.setText("Progress : "+progressStatus+"%");

                                }
                            });
                        }

                        // Hide the progress bar when done
                        if(progressStatus >=100 ){
                            handler.post(new Runnable() {
                                @Override
                                public void run() {
                                    progressBar.setVisibility(View.GONE);
                                }
                            });
                        }
                    }
                }).start();
            }
        });

        ViewCompat.setOnApplyWindowInsetsListener(findViewById(R.id.main), (v, insets) -> {
            Insets systemBars = insets.getInsets(WindowInsetsCompat.Type.systemBars());
            v.setPadding(systemBars.left, systemBars.top, systemBars.right, systemBars.bottom);
            return insets;
        });
    }
}