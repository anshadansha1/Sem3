package com.example.android_events;

import android.annotation.SuppressLint;
import android.os.Bundle;

import androidx.activity.EdgeToEdge;
import androidx.appcompat.app.AppCompatActivity;
import androidx.core.graphics.Insets;
import androidx.core.view.ViewCompat;
import androidx.core.view.WindowInsetsCompat;

//Import
import android.view.View;
import android.widget.Button;
import android.widget.TextView;
import android.widget.AdapterView;
import android.widget.ArrayAdapter;
import android.widget.ListView;
import android.widget.Toast;
import androidx.constraintlayout.widget.ConstraintLayout;
import android.view.MotionEvent;

public class MainActivity extends AppCompatActivity {

    String[] namesArray = {"Anshad Muhammad","Dilsha C p","Nihal Muhammad","Majo","Abhinav M S","Albin","SreeKumar","Rahul","Hari"};
    @SuppressLint("ClickableViewAccessibility")
    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        EdgeToEdge.enable(this);
        setContentView(R.layout.activity_main);

        //Implementing Button Click event:
        Button b1 = (Button)findViewById(R.id.b1);
        TextView tv1 = (TextView)findViewById(R.id.tv1);

        //Set onClickListener :
        b1.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                tv1.setText("Button is Clicked");
            }
        });

        //Implement Long Click Event on Listview:
        ListView lv1 = findViewById(R.id.lv1);
        ArrayAdapter adapter = new ArrayAdapter(this, android.R.layout.simple_list_item_1,namesArray);
        lv1.setAdapter(adapter);
        lv1.setOnItemLongClickListener(new AdapterView.OnItemLongClickListener() {
            @Override
            public boolean onItemLongClick(AdapterView<?> adapterView, View view, int i, long l) {
                Toast.makeText(getApplicationContext(),"Long Clicked",Toast.LENGTH_SHORT).show();
                return true;
            }
        });

        //Implement a Touch event :
        ConstraintLayout myView  =(ConstraintLayout)findViewById(R.id.main);
        myView.setOnTouchListener(new View.OnTouchListener() {
            @Override
            public boolean onTouch(View view, MotionEvent motionEvent) {
                //Handle touch here :
                Toast.makeText(MainActivity.this,"Touch Event",Toast.LENGTH_SHORT).show();
                return true;
            }
        });


        ViewCompat.setOnApplyWindowInsetsListener(findViewById(R.id.main), (v, insets) -> {
            Insets systemBars = insets.getInsets(WindowInsetsCompat.Type.systemBars());
            v.setPadding(systemBars.left, systemBars.top, systemBars.right, systemBars.bottom);
            return insets;
        });
    }
}