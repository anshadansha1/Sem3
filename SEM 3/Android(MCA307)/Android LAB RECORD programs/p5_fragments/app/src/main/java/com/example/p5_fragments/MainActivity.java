package com.example.p5_fragments;

import android.os.Bundle;

import androidx.activity.EdgeToEdge;
import androidx.appcompat.app.AppCompatActivity;
import androidx.core.graphics.Insets;
import androidx.core.view.ViewCompat;
import androidx.core.view.WindowInsetsCompat;

//import
import android.widget.Button;
import android.view.View;
import androidx.fragment.app.Fragment;
import androidx.fragment.app.FragmentManager;
import androidx.fragment.app.FragmentTransaction;


public class MainActivity extends AppCompatActivity {

    //declare
    private boolean isFragmentOne = true;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        EdgeToEdge.enable(this);
        setContentView(R.layout.activity_main);

        //Step 1:Load Initial Fragment
        loadFragment(new FragementOne());

        //Step 2 : Set up button to switch Fragments
        Button buttonswitch = findViewById(R.id.buttonSwitch);
        buttonswitch.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                if(isFragmentOne){
                    loadFragment(new FragmentTwo());
                }else{
                    loadFragment(new FragementOne());
                }
                isFragmentOne = !isFragmentOne;
            }
        });

        ViewCompat.setOnApplyWindowInsetsListener(findViewById(R.id.main), (v, insets) -> {
            Insets systemBars = insets.getInsets(WindowInsetsCompat.Type.systemBars());
            v.setPadding(systemBars.left, systemBars.top, systemBars.right, systemBars.bottom);
            return insets;
        });
    }

    private void loadFragment(Fragment fragment){
        //Raplacing current fragment with new one
        FragmentManager fragmentManager = getSupportFragmentManager();
        FragmentTransaction fragmentTransaction = fragmentManager.beginTransaction();
        fragmentTransaction.replace(R.id.fragment_container,fragment);
        fragmentTransaction.commit();
    }
}