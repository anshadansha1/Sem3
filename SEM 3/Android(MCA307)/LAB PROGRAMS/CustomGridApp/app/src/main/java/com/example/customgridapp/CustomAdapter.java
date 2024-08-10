package com.example.customgridapp;

import android.view.View;
import android.view.ViewGroup;
import android.widget.BaseAdapter;

//import
import android.widget.TextView;
import android.widget.ImageView;
import android.content.Context;
import android.view.LayoutInflater;
public class CustomAdapter extends BaseAdapter {
    private Context context;
    private final String[] items;
    private final int[] ImageIds;

    public CustomAdapter(Context context,String[] items ,int[] Ima)
        this.context = context;
        this.items= items;
        this.ImageIds=ImageIds;
    @Override
    public int getCount() {
        return 0;
    }

    @Override
    public Object getItem(int i) {
        return null;
    }

    @Override
    public long getItemId(int i) {
        return 0;
    }

    @Override
    public View getView(int i, View view, ViewGroup viewGroup) {
        return null;
    }
}
