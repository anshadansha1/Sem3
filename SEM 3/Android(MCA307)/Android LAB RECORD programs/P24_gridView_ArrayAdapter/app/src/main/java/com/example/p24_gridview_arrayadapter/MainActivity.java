package com.example.p24_gridview_arrayadapter;

import android.os.Bundle;

import androidx.activity.EdgeToEdge;
import androidx.appcompat.app.AppCompatActivity;
import androidx.core.graphics.Insets;
import androidx.core.view.ViewCompat;
import androidx.core.view.WindowInsetsCompat;

//import
import android.widget.ArrayAdapter;
import android.widget.GridView;

public class MainActivity extends AppCompatActivity {

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        EdgeToEdge.enable(this);
        setContentView(R.layout.activity_main);

        //Step 1 : Find the GridView by its ID
        GridView gridView = findViewById(R.id.gridView);

        //Step 2 : Create a List of items to display in the GridView
        String[] items = {
                "Anshad", "MCA", "36",
                "Dilsha", "MCA", "18",
                "Hari", "MSC CS", "22",
                "Aisha", "BCA", "25",
                "Rahul", "MCA", "30",
                "Priya", "MBA", "28",
                "Vikram", "MSC CS", "20",
                "Rohan", "MBA", "29",
                "Meera", "BSc IT", "19",
                "Arjun", "MCA", "35",
                "Riya", "MSC CS", "21",
                "Suresh", "BCA", "27",
                "Nisha", "MBA", "26",
                "Ravi", "MCA", "32",
                "Pooja", "MSC CS", "23",
                "Karan", "BSc IT", "17",
                "Simran", "MBA", "31",
                "Aman", "BCA", "20",
                "Tara", "MCA", "34",
                "Jay", "MSC CS", "22",
                "Anita", "BSc IT", "18",
                "Deepak", "MCA", "33",
                "Lina", "MBA", "27",
                "Vikas", "BCA", "21",
                "Komal", "MSC CS", "19",
                "Raj", "MCA", "37",
                "Sonia", "MBA", "29",
                "Rohit", "BSc IT", "20",
                "Neha", "MCA", "35"
        };

        //Step 3 : Create an ArrayAdapter to Link the array to the Gridview
        ArrayAdapter<String> adapter = new ArrayAdapter<>(
                this,
                android.R.layout.simple_list_item_1,
                items
        );

        //Step 4 : Set the adapter to the gridview
        gridView.setAdapter(adapter);

        ViewCompat.setOnApplyWindowInsetsListener(findViewById(R.id.main), (v, insets) -> {
            Insets systemBars = insets.getInsets(WindowInsetsCompat.Type.systemBars());
            v.setPadding(systemBars.left, systemBars.top, systemBars.right, systemBars.bottom);
            return insets;
        });
    }
}