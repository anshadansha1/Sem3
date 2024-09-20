package com.example.p27_asynctask;

import android.os.Bundle;

import androidx.activity.EdgeToEdge;
import androidx.appcompat.app.AppCompatActivity;
import androidx.core.graphics.Insets;
import androidx.core.view.ViewCompat;
import androidx.core.view.WindowInsetsCompat;

//Import
import android.os.AsyncTask;
import android.view.View;
import android.widget.Button;
import android.widget.ProgressBar;
import android.widget.TextView;

public class MainActivity extends AppCompatActivity {

    //Declare
    private ProgressBar progressBar;
    private TextView textViewProgress;
    private Button buttonStartTask;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        EdgeToEdge.enable(this);
        setContentView(R.layout.activity_main);

        progressBar = findViewById(R.id.progressBar);
        textViewProgress = findViewById(R.id.tvProgress);
        buttonStartTask = findViewById(R.id.buttonStart);

        buttonStartTask.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                // Start the AsyncTask
                new MyAsyncTask().execute();
            }
        });

        ViewCompat.setOnApplyWindowInsetsListener(findViewById(R.id.main), (v, insets) -> {
            Insets systemBars = insets.getInsets(WindowInsetsCompat.Type.systemBars());
            v.setPadding(systemBars.left, systemBars.top, systemBars.right, systemBars.bottom);
            return insets;
        });
    }

    // AsyncTask class to perform the background task
    private class MyAsyncTask extends AsyncTask<Void, Integer, String> {

        @Override
        protected void onPreExecute() {
            super.onPreExecute();
            // Show the progress bar before the task starts
            progressBar.setVisibility(View.VISIBLE);
            textViewProgress.setText("Task Progress: 0%");
        }

        @Override
        protected String doInBackground(Void... voids) {
            // Simulate a task by updating progress
            for (int i = 1; i <= 100; i++) {
                try {
                    // Sleep to simulate a time-consuming task
                    Thread.sleep(50);
                } catch (InterruptedException e) {
                    e.printStackTrace();
                }
                // Update the progress
                publishProgress(i);
            }
            // Return the result when the task is complete
            return "Task Completed!";
        }

        @Override
        protected void onProgressUpdate(Integer... values) {
            super.onProgressUpdate(values);
            // Update the progress bar and text view with the current progress
            progressBar.setProgress(values[0]);
            textViewProgress.setText("Task Progress: " + values[0] + "%");
        }

        @Override
        protected void onPostExecute(String result) {
            super.onPostExecute(result);
            // Hide the progress bar and display the result
            progressBar.setVisibility(View.GONE);
            textViewProgress.setText(result);
        }
    }
}