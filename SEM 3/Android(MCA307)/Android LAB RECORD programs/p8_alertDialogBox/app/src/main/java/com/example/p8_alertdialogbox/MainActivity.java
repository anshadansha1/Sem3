package com.example.p8_alertdialogbox;

import android.content.DialogInterface;
import android.os.Build;
import android.os.Bundle;
import android.view.View;
import android.widget.Button;

import androidx.activity.EdgeToEdge;
import androidx.appcompat.app.AlertDialog;
import androidx.appcompat.app.AppCompatActivity;
import androidx.core.graphics.Insets;
import androidx.core.view.ViewCompat;
import androidx.core.view.WindowInsetsCompat;

public class MainActivity extends AppCompatActivity {

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        EdgeToEdge.enable(this);
        setContentView(R.layout.activity_main);

        //CODE
        Button buttonAlert = findViewById(R.id.buttonAlert);
        buttonAlert.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                //Step 1 : Create an Alert Dialog Builder
                AlertDialog.Builder builder = new AlertDialog.Builder(MainActivity.this);

                //Step 2 : Set the message and Title
                builder.setTitle("Security Alert!").setMessage("Do you want to continue?");

                //Step 3 : Set cancelable true : When the User clicks outside the dialog box the it will Disappear
                builder.setCancelable(true);

                //Step 4 : Add the Buttons , Display "YES" and "No".
                builder.setPositiveButton("Yes", new DialogInterface.OnClickListener() {
                    @Override
                    public void onClick(DialogInterface dialogInterface, int i) {
                        //When user taps OK button ,Continues in the screen and Dialog box cancels.
                        dialogInterface.cancel();
                    }
                });
                builder.setNegativeButton("No", new DialogInterface.OnClickListener() {
                    @Override
                    public void onClick(DialogInterface dialogInterface, int i) {
                        //User Cancels the dialog ,Goes Back
                        finish();
                    }
                });

                //Step 5 :Create the AlertDialog
                AlertDialog dialog = builder.create();
                builder.show();



            }
        });
        ViewCompat.setOnApplyWindowInsetsListener(findViewById(R.id.main), (v, insets) -> {
            Insets systemBars = insets.getInsets(WindowInsetsCompat.Type.systemBars());
            v.setPadding(systemBars.left, systemBars.top, systemBars.right, systemBars.bottom);
            return insets;
        });
    }
}