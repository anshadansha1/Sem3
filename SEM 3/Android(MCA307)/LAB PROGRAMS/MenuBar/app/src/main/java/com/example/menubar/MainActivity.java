package com.example.menubar;

import android.os.Bundle;

import androidx.activity.EdgeToEdge;
import androidx.appcompat.app.AppCompatActivity;
import androidx.core.graphics.Insets;
import androidx.core.view.ViewCompat;
import androidx.core.view.WindowInsetsCompat;

//import menu :

import android.view.Menu;
import android.view.MenuInflater;
import android.view.MenuItem;
import android.widget.Toast;
import androidx.appcompat.widget.Toolbar;

public class MainActivity extends AppCompatActivity {

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        EdgeToEdge.enable(this);
        setContentView(R.layout.activity_main);

        Toolbar toolbar = findViewById(R.id.toolbar);
        setSupportActionBar(toolbar);

        ViewCompat.setOnApplyWindowInsetsListener(findViewById(R.id.main), (v, insets) -> {
            Insets systemBars = insets.getInsets(WindowInsetsCompat.Type.systemBars());
            v.setPadding(systemBars.left, systemBars.top, systemBars.right, systemBars.bottom);
            return insets;
        });
    }

    @Override
    public boolean onCreateOptionsMenu(Menu menu) {
        MenuInflater inflater = getMenuInflater();
        inflater.inflate(R.menu.menu1, menu);
        return true;
    }

    @Override
    public boolean onOptionsItemSelected(MenuItem item) {
        //Handling item:
        if (item.getItemId() == R.id.item1)
            Toast.makeText(MainActivity.this, "Selected Kerala", Toast.LENGTH_LONG).show();
        if (item.getItemId() == R.id.item2)
            Toast.makeText(MainActivity.this, "Selected Tamil Nadu", Toast.LENGTH_LONG).show();
        if (item.getItemId() == R.id.item3)
            Toast.makeText(MainActivity.this, "Selected Karnataka", Toast.LENGTH_LONG).show();
        if (item.getItemId() == R.id.item4)
            Toast.makeText(MainActivity.this, "Selected Andra Pradesh", Toast.LENGTH_LONG).show();
        if (item.getItemId() == R.id.item5)
            Toast.makeText(MainActivity.this, "Selected Gujarat", Toast.LENGTH_LONG).show();
        if (item.getItemId() == R.id.item6)
            Toast.makeText(MainActivity.this, "Selected Punjab", Toast.LENGTH_LONG).show();
        if (item.getItemId() == R.id.item7_1)
            Toast.makeText(MainActivity.this, "Selected Goa", Toast.LENGTH_LONG).show();
        if (item.getItemId() == R.id.item7_2)
            Toast.makeText(MainActivity.this, "Selected Jammu", Toast.LENGTH_LONG).show();
        return super.onOptionsItemSelected(item);
    }


}