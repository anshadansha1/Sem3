package com.example.p16_suminnextactivity_intent;

import android.content.Intent;
import android.os.Bundle;
import android.view.View;
import android.widget.EditText;

import androidx.activity.EdgeToEdge;
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


        ViewCompat.setOnApplyWindowInsetsListener(findViewById(R.id.main), (v, insets) -> {
            Insets systemBars = insets.getInsets(WindowInsetsCompat.Type.systemBars());
            v.setPadding(systemBars.left, systemBars.top, systemBars.right, systemBars.bottom);
            return insets;
        });
    }

    public void calculateSum(View v){
        //Intialize
        EditText et1 = findViewById(R.id.et1);
        EditText et2 = findViewById(R.id.et2);

        //Declare variables to get values from inputtext
        int num1 = Integer.parseInt(et1.getText().toString());
        int num2 = Integer.parseInt(et2.getText().toString());

        //Intent
        Intent intent = new Intent(MainActivity.this,ResultActivity.class);
        //To pass values to ResultActivity
        intent.putExtra("message","Sum is :  ");
        intent.putExtra("a",num1);
        intent.putExtra("b",num2);
        startActivity(intent);

    }
}