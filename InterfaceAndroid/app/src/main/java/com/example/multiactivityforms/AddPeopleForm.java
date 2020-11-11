package com.example.multiactivityforms;

import android.content.Intent;
import android.os.Bundle;

import com.google.android.material.floatingactionbutton.FloatingActionButton;
import com.google.android.material.snackbar.Snackbar;

import androidx.appcompat.app.AppCompatActivity;
import androidx.appcompat.widget.Toolbar;

import android.util.Log;
import android.view.View;
import android.widget.Button;
import android.widget.ListView;

import java.util.ArrayList;
import java.util.List;

public class AddPeopleForm extends AppCompatActivity {

    ListView list;
    ListView listPhones;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_add_people_form);

        this.list = (ListView) this.findViewById(R.id.listAddresses);
        this.listPhones = (ListView) this.findViewById(R.id.listPhones);

        AddPeopleForm.this.setTitle("Cadastrar Pessoa");

        Button addAddress = (Button) findViewById(R.id.btnAddAdress);
        addAddress.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                Log.i("AddPeopleForm", "onClick: Button Clicked!");
                Intent intent = new Intent(AddPeopleForm.this, AddAddressForm.class);
                startActivity(intent);
            }
        });

        Button addPhone = (Button) findViewById(R.id.btnAddPhones);
        addPhone.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                Log.i("AddPeopleForm", "onClick: Button Clicked!");
                Intent intent = new Intent(AddPeopleForm.this, AddPhoneForm.class);
                startActivity(intent);
            }
        });
    }

    @Override
    protected void onResume() {
        loadAddress();
        loadPhone();
        super.onResume();
    }

    void loadAddress()
    {
        List<Address> addresses = new ArrayList<Address>();

        // create address
        Address address1 = new Address();
        address1.setId(1L);
        address1.setLogradouro("Rua Bezerra de Menezes");
        address1.setNumero(174L);
        address1.setCEP(13611251L);
        address1.setBairro("Santa Rita");
        address1.setCidade("Leme");
        address1.setEstado("São Paulo");

        addresses.add(address1);

        AddressAdapter aa = new AddressAdapter(addresses);
        this.list.setAdapter(aa);
    }

    void loadPhone()
    {
        List<Phone> telefones = new ArrayList<Phone>();

        // create phone
        Phone phone1 = new Phone();
        phone1.setId(1L);
        phone1.setDDD(11L);
        phone1.setNumero(954770271L);
        phone1.setTipo("celular");

        Phone phone2 = new Phone();
        phone2.setId(1L);
        phone2.setDDD(11L);
        phone2.setNumero(30532525L);
        phone2.setTipo("residencial");

        telefones.add(phone1);
        telefones.add(phone2);

        PhoneAdapter pa = new PhoneAdapter(telefones);
        this.listPhones.setAdapter(pa);
    }
}