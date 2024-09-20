package com.example.p19_system_intent_broadcast_airplanemode;

import android.content.Intent;
import android.content.IntentFilter;
import android.os.Bundle;
import android.widget.TextView;

import androidx.activity.EdgeToEdge;
import androidx.appcompat.app.AppCompatActivity;
import androidx.core.graphics.Insets;
import androidx.core.view.ViewCompat;
import androidx.core.view.WindowInsetsCompat;

public class MainActivity extends AppCompatActivity {

    //Declaration
    private  AirplaneModeReceiver airplaneModeReceiver;
    private TextView textViewAirplaneMode;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        EdgeToEdge.enable(this);
        setContentView(R.layout.activity_main);

        //Initialize
        textViewAirplaneMode = findViewById(R.id.tvAirplane);
        airplaneModeReceiver = new AirplaneModeReceiver();

        ViewCompat.setOnApplyWindowInsetsListener(findViewById(R.id.main), (v, insets) -> {
            Insets systemBars = insets.getInsets(WindowInsetsCompat.Type.systemBars());
            v.setPadding(systemBars.left, systemBars.top, systemBars.right, systemBars.bottom);
            return insets;
        });
    }

    @Override
    protected  void onStart(){
        super.onStart();
        //Register the receiver to listen for the AIRPLANE_MODE_CHANGED event
        IntentFilter filter = new IntentFilter(Intent.ACTION_AIRPLANE_MODE_CHANGED);
        registerReceiver(airplaneModeReceiver,filter);
    }

    @Override
    protected  void onStop(){
        super.onStop();
        //Unregister the receiver when the activity is stopped to save Resources
        unregisterReceiver(airplaneModeReceiver);
    }

}