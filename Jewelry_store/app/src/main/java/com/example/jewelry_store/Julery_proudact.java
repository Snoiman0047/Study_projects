package com.example.jewelry_store;

import androidx.appcompat.app.AppCompatActivity;

import android.content.Intent;
import android.graphics.Color;
import android.os.Bundle;
import android.view.View;
import android.widget.AdapterView;
import android.widget.ArrayAdapter;
import android.widget.Button;
import android.widget.EditText;
import android.widget.ImageView;
import android.widget.ListView;
import android.widget.TextView;
import android.widget.Toast;

import org.w3c.dom.Text;

import java.util.ArrayList;

public class Julery_proudact extends AppCompatActivity {

    String User_name;
    TextView tv;
    ArrayList<String> Julery_list;
    ListView lv;
    Button Add, Remove, Price;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_julery_proudact);
        setTitle("Julary catalog");

        User_name = getIntent().getStringExtra("User_name");
        tv = (TextView) findViewById(R.id.Title);
        tv.setText(User_name + ", Welcome back!");

        Julery_list = new ArrayList<String>();
        Julery_list.add("Necklaces");
        Julery_list.add("Earrings");
        Julery_list.add("Watches");
        Julery_list.add("Bracelets");
        Julery_list.add("Rings");

        ArrayAdapter<String> Julery_adapter = new ArrayAdapter<String>(this, android.R.layout.simple_list_item_1, Julery_list);
        lv = (ListView) findViewById(R.id.Julery_list);
        lv.setAdapter(Julery_adapter);

        Price = (Button) findViewById(R.id.button6);
        Price.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) { Next_page(v); }});

        Add = (Button) findViewById(R.id.add_but);
        Add.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                EditText et = (EditText) findViewById(R.id.add_julary);
                Julery_list.add(String.valueOf(et.getText()));
                lv.setAdapter(Julery_adapter);
            }
        });

        Remove = (Button) findViewById(R.id.remove_but);
        final String[] s = {""};
        lv.setOnItemClickListener(new AdapterView.OnItemClickListener() {
            @Override
            public void onItemClick(AdapterView<?> parent, View view, int position, long id) {
                s[0] = Julery_list.get(position);
            }
        });
        Remove.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                Julery_list.remove(String.valueOf(s[0]));
                lv.setAdapter(Julery_adapter);
            }
        });
    }

    public void Next_page (View v)
    {
        Intent in = new Intent();
        in.setClass(this, Julary_prices.class);
        startActivity(in);
    }
}