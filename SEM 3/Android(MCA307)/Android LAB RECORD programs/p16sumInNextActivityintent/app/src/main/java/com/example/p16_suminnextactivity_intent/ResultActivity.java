package com.example.p16_suminnextactivity_intent;

import android.os.Bundle;
import android.widget.TextView;

import androidx.activity.EdgeToEdge;
import androidx.appcompat.app.AppCompatActivity;
import androidx.core.graphics.Insets;
import androidx.core.view.ViewCompat;
import androidx.core.view.WindowInsetsCompat;

public class ResultActivity extends AppCompatActivity {

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        EdgeToEdge.enable(this);
        setContentView(R.layout.activity_result);
        ViewCompat.setOnApplyWindowInsetsListener(findViewById(R.id.main), (v, insets) -> {
            Insets systemBars = insets.getInsets(WindowInsetsCompat.Type.systemBars());
            v.setPadding(systemBars.left, systemBars.top, systemBars.right, systemBars.bottom);
            return insets;
        });

        //To get Passe Values use Bundle
        Bundle e = getIntent().getExtras();
        if(e!=null){
            TextView textView=findViewById(R.id.tv3);
            //Getting passe values and Storing in values
            String msg = e.getString("message");

            int num1 = e.getInt("a");
            int num2 = e.getInt("b");
            int sum  = num1 + num2 ;
            textView.setText(msg+sum);
        }
    }


}