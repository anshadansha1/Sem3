package com.example.p25_customgridview_using_baseadapter;

import android.os.Bundle;

import androidx.activity.EdgeToEdge;
import androidx.appcompat.app.AppCompatActivity;
import androidx.core.graphics.Insets;
import androidx.core.view.ViewCompat;
import androidx.core.view.WindowInsetsCompat;

//import
import android.widget.GridView;
import androidx.appcompat.app.AppCompatActivity;

public class MainActivity extends AppCompatActivity {

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        EdgeToEdge.enable(this);
        setContentView(R.layout.activity_main);

        //CODE
        GridView gridView = findViewById(R.id.gridView);

        // Data to be displayed
        String[] itemNames = {
                "Item 1", "Item 2", "Item 3",
                "Item 4", "Item 5", "Item 6",
                "Item 7", "Item 8", "Item 9"
        };

        // Images for the items
        int[] itemImages = {
                R.drawable.image1, R.drawable.image2, R.drawable.image3,
                R.drawable.image4, R.drawable.image5, R.drawable.image6,
                R.drawable.image7, R.drawable.image8, R.drawable.image9
        };

        // Create an instance of CustomGridAdapter
        CustomGridAdapter adapter = new CustomGridAdapter(this, itemNames, itemImages);

        // Set the adapter to the GridView
        gridView.setAdapter(adapter);

        ViewCompat.setOnApplyWindowInsetsListener(findViewById(R.id.main), (v, insets) -> {
            Insets systemBars = insets.getInsets(WindowInsetsCompat.Type.systemBars());
            v.setPadding(systemBars.left, systemBars.top, systemBars.right, systemBars.bottom);
            return insets;
        });
    }
}