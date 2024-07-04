package com.example.fooddelevery;

public class FoodItem {
    private String name;
    private String description;
    private String price;
    private int imageResId;

    public FoodItem(String name, String description, String price, int imageResId) {
        this.name = name;
        this.description = description;
        this.price = price;
        this.imageResId = imageResId;
    }

    public String getName() {
        return name;
    }

    public String getDescription() {
        return description;
    }

    public String getPrice() {
        return price;
    }

    public int getImageResId() {
        return imageResId;
    }
}

