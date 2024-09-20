package com.example.p18_custom_intent;

import android.content.BroadcastReceiver;
import android.content.Context;
import android.content.Intent;
import android.widget.Toast;

public class MyBroadcastReceiver extends BroadcastReceiver{
    @Override
    public void onReceive(Context context,Intent intent){
        //Display a Toast when the custom intent is received
        Toast.makeText(context, "Custom Intent Received!", Toast.LENGTH_LONG).show();
    }
}
