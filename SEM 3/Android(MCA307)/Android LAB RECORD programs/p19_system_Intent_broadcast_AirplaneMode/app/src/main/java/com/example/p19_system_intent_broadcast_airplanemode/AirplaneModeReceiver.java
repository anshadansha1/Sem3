package com.example.p19_system_intent_broadcast_airplanemode;

import android.content.BroadcastReceiver;
import android.content.Context;
import android.content.Intent;
import android.widget.Toast;

public class AirplaneModeReceiver extends BroadcastReceiver {
    @Override
    public void onReceive(Context context, Intent intent){
        if(Intent.ACTION_AIRPLANE_MODE_CHANGED.equals(intent.getAction())){
            //Check if Airplane mode is Enables or Not
            boolean isAirplaneModeOn = intent.getBooleanExtra("state",false);

            //Display a Toast message for user feedback
            if(isAirplaneModeOn){
                Toast.makeText(context, "Airplane Mode is ON", Toast.LENGTH_SHORT).show();
            }else{
                Toast.makeText(context, "Airplane Mode is Off", Toast.LENGTH_SHORT).show();
            }
        }
    }
}
