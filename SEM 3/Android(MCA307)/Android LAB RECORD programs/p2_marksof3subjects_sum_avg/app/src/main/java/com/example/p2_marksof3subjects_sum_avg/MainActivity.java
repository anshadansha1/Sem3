package com.example.p2_marksof3subjects_sum_avg;

import android.os.Bundle;

import androidx.activity.EdgeToEdge;
import androidx.appcompat.app.AppCompatActivity;
import androidx.core.graphics.Insets;
import androidx.core.view.ViewCompat;
import androidx.core.view.WindowInsetsCompat;

//import
import android.widget.Button;
import android.widget.EditText;
import android.widget.TextView;
import android.view.View;


public class MainActivity extends AppCompatActivity {

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        EdgeToEdge.enable(this);
        setContentView(R.layout.activity_main);

        //Step 1:Intialize
        EditText etsubject1 = findViewById(R.id.etSubject1);
        EditText etsubject2 = findViewById(R.id.etSubject2);
        EditText etsubject3 = findViewById(R.id.etSubject3);
        Button bcalc = findViewById(R.id.buttonCalc);
        TextView tvsum = findViewById(R.id.tvSum);
        TextView tvavg = findViewById(R.id.tvAvg);

        //Step 2: Set onClickListener for Button
        bcalc.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                //Step 3 : Get input marks from user
                int mark1 = Integer.parseInt(etsubject1.getText().toString());
                int mark2 = Integer.parseInt(etsubject2.getText().toString());
                int mark3 = Integer.parseInt(etsubject3.getText().toString());

                //Step 4 : Calculate Sum and Avg
                int sum = mark1 + mark2 + mark3 ;
                double avg = sum / 3.0 ;

                //Step 5 : Display results in Textviews
                tvsum.setText("Sum = "+sum);
                tvavg.setText("Average = "+avg);

            }
        });


        ViewCompat.setOnApplyWindowInsetsListener(findViewById(R.id.main), (v, insets) -> {
            Insets systemBars = insets.getInsets(WindowInsetsCompat.Type.systemBars());
            v.setPadding(systemBars.left, systemBars.top, systemBars.right, systemBars.bottom);
            return insets;
        });
    }

}