package com.example.fooddelivery;
import android.os.Bundle;
import android.widget.ListView;
import androidx.appcompat.app.AppCompatActivity;
import java.util.ArrayList;
import java.util.List;

public class MainActivity extends AppCompatActivity {

    private ListView foodListView;
    private FoodItemAdapter foodItemAdapter;
    private List<FoodItem> foodItemList;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);

        foodListView = findViewById(R.id.food_list_view);

        foodItemList = new ArrayList<>();
        foodItemList.add(new FoodItem("Mojito", " Refreshment", 90, R.drawable.mojito));
        foodItemList.add(new FoodItem("Biriyani", " Dhum biriyani", 160, R.drawable.biriyani));
        foodItemList.add(new FoodItem("Burger", " Jumbo burger", 220, R.drawable.burger));
        foodItemList.add(new FoodItem("Dosa", " Masala Dosa ", 80, R.drawable.dosa));
        foodItemList.add(new FoodItem("Loaded Fries", " Fries with loaded chicken topings", 180, R.drawable.loaded_fries));
        foodItemList.add(new FoodItem("Mandi", " Alfaham Mandi", 220, R.drawable.mandi));
        foodItemList.add(new FoodItem("Momos", " Fried Momos", 120, R.drawable.momos));
        foodItemList.add(new FoodItem("Payasam", " Adapradhaman", 160, R.drawable.payasam));
        foodItemList.add(new FoodItem("Pizza", " Chicken Suasage pizaa", 199, R.drawable.pizza));
        foodItemList.add(new FoodItem("Porotta Beef", " Porotta with Beef", 120, R.drawable.porotta));
        foodItemList.add(new FoodItem("Russian", " Honey Cake", 180, R.drawable.russian_honey_cake));
        foodItemList.add(new FoodItem("Sandwich", " Special Sanddwich", 180, R.drawable.sandwich));
        foodItemList.add(new FoodItem("Shawarma", " jumbo shawarma", 220, R.drawable.shawarma));



        foodItemAdapter = new FoodItemAdapter(this, foodItemList);
        foodListView.setAdapter(foodItemAdapter);
    }
}
