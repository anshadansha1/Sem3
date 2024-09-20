package com.example.p18_custom_intent;


import android.content.ComponentName;
import android.content.Intent;
import android.os.Bundle;
import android.view.View;
import android.widget.Button;
import androidx.appcompat.app.AppCompatActivity;

public class MainActivity extends AppCompatActivity {

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);

        Button buttonBroadcast = findViewById(R.id.buttonBroadcast);
        buttonBroadcast.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                // Create and send a custom broadcast intent
                Intent intent = new Intent();
                intent.setAction("com.example.CUSTOM_INTENT");

                // Explicitly set the component to target MyBroadcastReceiver
                intent.setComponent(new ComponentName(getPackageName(), MyBroadcastReceiver.class.getName()));

                sendBroadcast(intent);
            }
        });
    }
}
