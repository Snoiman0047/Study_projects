package com.example.jewelry_store;

import androidx.annotation.RequiresApi;
import androidx.appcompat.app.AlertDialog;
import androidx.appcompat.app.AppCompatActivity;

import android.content.DialogInterface;
import android.os.Build;
import android.os.Bundle;
import android.view.View;
import android.widget.Button;
import android.widget.Toolbar;

public class Julary_prices extends AppCompatActivity{

    Button N, E, W, B, Ri;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_julary_prices);

        N = (Button) findViewById(R.id.button);
        N.setOnClickListener(new View.OnClickListener() { @Override public void onClick(View v) { Alert("1599"); }});

        E = (Button) findViewById(R.id.button2);
        E.setOnClickListener(new View.OnClickListener() { @Override public void onClick(View v) { Alert("410"); }});

        W = (Button) findViewById(R.id.button3);
        W.setOnClickListener(new View.OnClickListener() { @Override public void onClick(View v) { Alert("970"); }});

        B = (Button) findViewById(R.id.button4);
        B.setOnClickListener(new View.OnClickListener() { @Override public void onClick(View v) { Alert("2574"); }});

        Ri = (Button) findViewById(R.id.button5);
        Ri.setOnClickListener(new View.OnClickListener() { @Override public void onClick(View v) { Alert("254"); }});

    }


   public void Alert(String price)
   {
       AlertDialog.Builder ad = new AlertDialog.Builder(this);
       ad.setTitle("Price");
       ad.setMessage("Price item to pay: " + price);
       ad.setNegativeButton("Exit", new DialogInterface.OnClickListener() {
           @Override
           public void onClick(DialogInterface arg0, int arg1) {
               arg0.cancel();
           }});
       AlertDialog d = ad.create();
       d.show();
   };

}