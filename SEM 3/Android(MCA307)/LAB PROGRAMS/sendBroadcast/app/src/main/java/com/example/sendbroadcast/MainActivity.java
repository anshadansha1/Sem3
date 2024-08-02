package com.example.sendbroadcast;

import android.content.Context;
import android.os.Bundle;
import android.view.View;
import android.content.Intent;
import android.content.IntentFilter;
import androidx.activity.EdgeToEdge;
import androidx.appcompat.app.AppCompatActivity;
import androidx.core.graphics.Insets;
import androidx.core.view.ViewCompat;
import androidx.core.view.WindowInsetsCompat;

public class MainActivity extends AppCompatActivity {
    MyReceiver receiver; //declaring Broadcast receiver

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

        // Call another function for receiving broadcast:
        configureReceiver();
    }

    public void sendBroadcast(View v){
        Intent intent = new Intent();
        intent.setAction("com.example.sendBroadcast").setPackage(getPackageName());; // Ensure this matches the action in IntentFilter
//        intent.addFlags(Intent.FLAG_INCLUDE_STOPPED_PACKAGES);
        sendBroadcast(intent);
    }

    // Function for receiver
    protected void configureReceiver(){
        IntentFilter filter = new IntentFilter();
        filter.addAction("com.example.broadcast");
        receiver = new MyReceiver();
        registerReceiver(receiver, filter, Context.RECEIVER_NOT_EXPORTED);


    }

    // [Optional] - To destroy receiver after use
    @Override
    protected void onDestroy(){
        super.onDestroy();
        unregisterReceiver(receiver);
    }
}
