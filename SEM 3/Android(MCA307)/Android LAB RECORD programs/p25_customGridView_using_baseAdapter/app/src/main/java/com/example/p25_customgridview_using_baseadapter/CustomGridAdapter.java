package com.example.p25_customgridview_using_baseadapter;

import android.content.Context;
import android.view.LayoutInflater;
import android.view.View;
import android.view.ViewGroup;
import android.widget.BaseAdapter;
import android.widget.ImageView;
import android.widget.TextView;

public class CustomGridAdapter extends BaseAdapter {
    private Context context;
    private final String[] itemNames;
    private final int[] itemImages;

    public CustomGridAdapter(Context context, String[] itemNames, int[] itemImages) {
        this.context = context;
        this.itemNames = itemNames;
        this.itemImages = itemImages;
    }

    @Override
    public int getCount() {
        return itemNames.length;
    }

    @Override
    public Object getItem(int position) {
        return null;
    }

    @Override
    public long getItemId(int position) {
        return 0;
    }

    @Override
    public View getView(int position, View convertView, ViewGroup parent) {
        View gridView = convertView;
        if (convertView == null) {
            LayoutInflater inflater = (LayoutInflater) context.getSystemService(Context.LAYOUT_INFLATER_SERVICE);
            gridView = inflater.inflate(R.layout.grid_item, null);
        }

        // Set data to the views
        ImageView imageView = gridView.findViewById(R.id.imageView);
        TextView textView = gridView.findViewById(R.id.textView);
        imageView.setImageResource(itemImages[position]);
        textView.setText(itemNames[position]);

        return gridView;
    }
}
