package com.example.radiobuttons_checkboxes;

import android.os.Bundle;

import androidx.activity.EdgeToEdge;
import androidx.appcompat.app.AppCompatActivity;
import androidx.core.graphics.Insets;
import androidx.core.view.ViewCompat;
import androidx.core.view.WindowInsetsCompat;

//import

import android.widget.CheckBox;
import android.widget.RadioButton;
import android.widget.RadioGroup;
import android.widget.EditText;
import android.view.View;

public class MainActivity extends AppCompatActivity {

    //define
    private RadioGroup radioGroup;
    private CheckBox cb1,cb2;
    private EditText editText;


    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        EdgeToEdge.enable(this);
        setContentView(R.layout.activity_main);

        //Code
        radioGroup = findViewById(R.id.rg1);
        cb1 = findViewById(R.id.checkbox1);
        cb2 = findViewById(R.id.checkbox2);
        editText = findViewById(R.id.etv2);


        ViewCompat.setOnApplyWindowInsetsListener(findViewById(R.id.main), (v, insets) -> {
            Insets systemBars = insets.getInsets(WindowInsetsCompat.Type.systemBars());
            v.setPadding(systemBars.left, systemBars.top, systemBars.right, systemBars.bottom);
            return insets;
        });
    }

    //Function:Register when clicked
    public void onSubmit(View v){
        //find id of currently selected radio button
        int selectedID = radioGroup.getCheckedRadioButtonId();

        //Assign it to a varibale
        RadioButton selected = findViewById(selectedID);

        //Extract the text from the radio button
        String selected_text = selected.getText().toString();

        //create a string to append thetexts from check box using StringBuilder class
        StringBuilder ch_text = new StringBuilder();
        if(cb1.isChecked()){
            ch_text.append(cb1.getText()).append(" , ");
        }
        if(cb2.isChecked()){
            ch_text.append(cb2.getText()).append(" ");
        }
        //display this on EditText
        editText.setText("Selected Course : "+selected_text+", Selected Category : "+ch_text);


    }


}