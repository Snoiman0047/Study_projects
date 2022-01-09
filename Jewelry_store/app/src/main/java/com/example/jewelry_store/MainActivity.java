package com.example.jewelry_store;

import androidx.annotation.RequiresApi;
import androidx.appcompat.app.AppCompatActivity;

import android.annotation.SuppressLint;
import android.content.Intent;
import android.graphics.Color;
import android.graphics.drawable.ColorDrawable;
import android.os.Build;
import android.os.Bundle;
import android.view.View;
import android.widget.Button;
import android.widget.EditText;
import android.widget.Toolbar;

import org.w3c.dom.Text;

public class MainActivity extends AppCompatActivity{

    EditText User_name;
    Button Sign_in;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);

        User_name = (EditText) findViewById(R.id.Username);

        Sign_in = (Button) findViewById(R.id.Loginbutton);
        Sign_in.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) { Next_page(v); }});
    }

    public void Next_page (View v)
    {
        Intent in = new Intent();
        in.setClass(this, Julery_proudact.class);
        in.putExtra("User_name",User_name.getText().toString() );
        startActivity(in);
    }
}