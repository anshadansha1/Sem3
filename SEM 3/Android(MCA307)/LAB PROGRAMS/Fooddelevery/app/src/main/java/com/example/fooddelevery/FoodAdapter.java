package com.example.fooddelevery;

import android.content.Context;
import android.view.LayoutInflater;
import android.view.View;
import android.view.ViewGroup;
import android.widget.ImageView;
import android.widget.TextView;

import androidx.annotation.NonNull;
import androidx.recyclerview.widget.RecyclerView;

import java.util.List;

public class FoodAdapter extends RecyclerView.Adapter<FoodAdapter.FoodViewHolder> {
    private Context context;
    private List<FoodItem> foodItemList;

    public FoodAdapter(Context context, List<FoodItem> foodItemList) {
        this.context = context;
        this.foodItemList = foodItemList;
    }

    @NonNull
    @Override
    public FoodViewHolder onCreateViewHolder(@NonNull ViewGroup parent, int viewType) {
        View view = LayoutInflater.from(context).inflate(R.layout.item_food, parent, false);
        return new FoodViewHolder(view);
    }

    @Override
    public void onBindViewHolder(@NonNull FoodViewHolder holder, int position) {
        FoodItem foodItem = foodItemList.get(position);
        holder.foodName.setText(foodItem.getName());
        holder.foodDescription.setText(foodItem.getDescription());
        holder.foodPrice.setText(foodItem.getPrice());
        holder.foodImage.setImageResource(foodItem.getImageResId());
    }

    @Override
    public int getItemCount() {
        return foodItemList.size();
    }

    public static class FoodViewHolder extends RecyclerView.ViewHolder {
        TextView foodName, foodDescription, foodPrice;
        ImageView foodImage;

        public FoodViewHolder(@NonNull View itemView) {
            super(itemView);
            foodName = itemView.findViewById(R.id.foodName);
            foodDescription = itemView.findViewById(R.id.foodDescription);
            foodPrice = itemView.findViewById(R.id.foodPrice);
            foodImage = itemView.findViewById(R.id.foodImage);
        }
    }
}

