package com.example.fooddelevery;

import android.os.Bundle;

import androidx.activity.EdgeToEdge;
import androidx.appcompat.app.AppCompatActivity;
import androidx.core.graphics.Insets;
import androidx.core.view.ViewCompat;
import androidx.core.view.WindowInsetsCompat;
import androidx.recyclerview.widget.LinearLayoutManager;
import androidx.recyclerview.widget.RecyclerView;
import java.util.ArrayList;
import java.util.List;

public class MainActivity extends AppCompatActivity {
    RecyclerView recyclerView;
    FoodAdapter foodAdapter;
    List<FoodItem> foodItemList;


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
        recyclerView = findViewById(R.id.recyclerView);
        recyclerView.setLayoutManager(new LinearLayoutManager(this));

        foodItemList = new ArrayList<>();
        foodItemList.add(new FoodItem("Porrota", "Beef", "$50", R.drawable.img1));
        foodItemList.add(new FoodItem("Sadhya", "Sambar,payasam,Resam", "$8", R.drawable.img3));
        foodItemList.add(new FoodItem("Payasam", "Semiya", "$15", R.drawable.img4));
        // Add more items as needed

        foodAdapter = new FoodAdapter(this, foodItemList);
        recyclerView.setAdapter(foodAdapter);
    }
}