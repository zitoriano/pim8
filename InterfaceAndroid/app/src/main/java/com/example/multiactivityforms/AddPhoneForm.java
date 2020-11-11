package com.example.multiactivityforms;

import androidx.appcompat.app.AppCompatActivity;

import android.os.Bundle;
import android.view.View;
import android.widget.ArrayAdapter;
import android.widget.Button;
import android.widget.Spinner;

public class AddPhoneForm extends AppCompatActivity {

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_add_phone_form);

        AddPhoneForm.this.setTitle("Cadastrar Telefone");

        Spinner spinner = (Spinner) findViewById(R.id.selectPhoneType);
        ArrayAdapter<CharSequence> adapter = ArrayAdapter.createFromResource(this,
                R.array.phonetype_array, android.R.layout.simple_spinner_item);
        adapter.setDropDownViewResource(android.R.layout.simple_spinner_dropdown_item);
        spinner.setAdapter(adapter);

        Button btnSavePhone = (Button) findViewById(R.id.btnSavePhone);
        btnSavePhone.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                AddPhoneForm.this.finish();
            }
        });
    }
}