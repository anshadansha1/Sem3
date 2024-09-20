package com.example.contextmenu;

import android.os.Bundle;

import androidx.activity.EdgeToEdge;
import androidx.appcompat.app.AppCompatActivity;
import androidx.core.graphics.Insets;
import androidx.core.view.ViewCompat;
import androidx.core.view.WindowInsetsCompat;

//
import android.view.ContextMenu;
import android.view.MenuItem;
import android.view.View;
import android.widget.TextView;
import android.graphics.Color;
import androidx.constraintlayout.widget.ConstraintLayout;

public class MainActivity extends AppCompatActivity {

    TextView textView;
    ConstraintLayout layout;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        EdgeToEdge.enable(this);
        setContentView(R.layout.activity_main);

        //Link those objects with respective id's that we have given in XML file
        textView = (TextView) findViewById(R.id.tv1);
        layout = (ConstraintLayout) findViewById(R.id.main);
        //Here you have to register a view for context menu.
        //You can register any view like listview . image View , textview , button etc.
        registerForContextMenu(textView);


        ViewCompat.setOnApplyWindowInsetsListener(findViewById(R.id.main), (v, insets) -> {
            Insets systemBars = insets.getInsets(WindowInsetsCompat.Type.systemBars());
            v.setPadding(systemBars.left, systemBars.top, systemBars.right, systemBars.bottom);
            return insets;
        });
    }

    @Override
    public void onCreateContextMenu(ContextMenu menu , View v , ContextMenu.ContextMenuInfo menuInfo){
        super.onCreateContextMenu(menu,v,menuInfo);
        //You can set menu header with title icon etc
        menu.setHeaderTitle("Choose a color");
        //Add menu items
        menu.add(0,v.getId(),0,"Yellow");
        menu.add(0,v.getId(),0,"Gray");
        menu.add(0,v.getId(),0,"Cyan");
    }

    //Menu item select listener:
    @Override
    public boolean onContextItemSelected(MenuItem item){
        if(item.getTitle() == "Yellow"){
            layout.setBackgroundColor(Color.YELLOW);
        }
        if(item.getTitle() == "Gray"){
            layout.setBackgroundColor(Color.GRAY);
        }
        if(item.getTitle() == "Cyan"){
            layout.setBackgroundColor(Color.CYAN);
        }
        return true;
    }
}