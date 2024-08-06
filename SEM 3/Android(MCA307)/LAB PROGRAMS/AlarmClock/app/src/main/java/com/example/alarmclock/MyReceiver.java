package com.example.alarmclock;

import android.content.BroadcastReceiver;
import android.content.Context;
import android.content.Intent;

import android.widget.Toast;
import android.media.Ringtone;
import android.media.RingtoneManager;
import android.net.Uri;

public class MyReceiver extends BroadcastReceiver {

    private static Ringtone ringtone;
    @Override
    public void onReceive(Context context, Intent intent) {
        // TODO: This method is called when the BroadcastReceiver is receiving
        // an Intent broadcast.
        Toast.makeText(context, "Wake up", Toast.LENGTH_SHORT).show();

        Uri alarmUri = RingtoneManager.getDefaultUri(RingtoneManager.TYPE_ALARM);
        if(alarmUri==null){
            alarmUri = RingtoneManager.getDefaultUri(RingtoneManager.TYPE_NOTIFICATION);
        }

        //Play alarm
        ringtone = RingtoneManager.getRingtone(context,alarmUri);
        ringtone.play();

    }

    //To stop playing
    public static void stopRingTone(){
        if(ringtone!=null && ringtone.isPlaying()){
            ringtone.stop();
        }
    }

}