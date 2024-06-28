package com.example.layouts;

import android.os.Bundle;

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

        //Code to switch between layouts when corresponding buttons are clicked:
        findViewById(R.id.l1).setOnClickListener(v -> setContentView(R.layout.linear_layout_example));
        findViewById(R.id.l2).setOnClickListener(v -> setContentView(R.layout.relative_layout_example));
        findViewById(R.id.l3).setOnClickListener(v -> setContentView(R.layout.frame_layout_example));
        findViewById(R.id.l4).setOnClickListener(v -> setContentView(R.layout.table_layout_example));

        ViewCompat.setOnApplyWindowInsetsListener(findViewById(R.id.main), (v, insets) -> {
            Insets systemBars = insets.getInsets(WindowInsetsCompat.Type.systemBars());
            v.setPadding(systemBars.left, systemBars.top, systemBars.right, systemBars.bottom);
            return insets;
        });
    }
}