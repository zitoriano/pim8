package com.example.multiactivityforms;

import androidx.appcompat.app.AppCompatActivity;

import com.example.multiactivityforms.Person;
import com.example.multiactivityforms.PersonAdapter;
import android.os.Bundle;
import android.util.Log;
import android.view.View;
import android.content.Intent;
import android.widget.ListView;

import com.google.android.material.floatingactionbutton.FloatingActionButton;

import java.util.ArrayList;
import java.util.List;

public class MainActivity extends AppCompatActivity {

    ListView list;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);

        this.list = (ListView) this.findViewById(R.id.listPeople);

        // Action Button
        FloatingActionButton fab = findViewById(R.id.addPeople);
        fab.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                Log.i("tag01", "onClick: Button clicked!");
                Intent intent = new Intent(MainActivity.this, AddPeopleForm.class);
                startActivity(intent);
            }
        });
    }

    @Override
    protected void onResume() {
        loadPeople();
        super.onResume();
    }

    void loadPeople() {
        List<Person> people = new ArrayList<Person>();

        // create person
        Person person1 = new Person();
        person1.setId(1L);
        person1.setNome("Diego Araujo Rocha");
        person1.setCpf(28192884562L);

        // add address
        Address address1 = new Address();
        address1.setLogradouro("Rua Carlos Novaes Franca");
        address1.setNumero(120L);
        address1.setCidade("Osasco");
        address1.setEstado("SP");
        person1.setAddress(address1);

        // add phone
        Phone phone1 = new Phone();
        phone1.setDDD(11L);
        phone1.setNumero(91231234L);
        phone1.setTipo("Celular");
        person1.addPhone(phone1);

        // create person
        Person person2 = new Person();
        person2.setId(2L);
        person2.setNome("Gabrielle Barros Barbosa");
        person2.setCpf(46369604089L);

        // add address
        Address address2 = new Address();
        address2.setLogradouro("Vila das Missões");
        address2.setNumero(11L);
        address2.setCidade("Fortaleza");
        address2.setEstado("CE");
        person2.setAddress(address2);

        // add phone
        Phone phone2 = new Phone();
        phone2.setDDD(85L);
        phone2.setNumero(9912366655L);
        phone2.setTipo("Celular");
        person2.addPhone(phone2);

        // create person
        Person person3 = new Person();
        person3.setId(3L);
        person3.setNome("Brenda Rodrigues Silva");
        person3.setCpf(29326160300L);

        // add address
        Address address3 = new Address();
        address3.setLogradouro("Rua Damianópolis");
        address3.setNumero(20L);
        address3.setCidade("Campo Grande");
        address3.setEstado("MS");
        person3.setAddress(address3);

        // add phone
        Phone phone3 = new Phone();
        phone3.setDDD(67L);
        phone3.setNumero(991234123L);
        phone3.setTipo("Celular");
        person3.addPhone(phone3);

        // create person
        Person person4 = new Person();
        person4.setId(4L);
        person4.setNome("Aline Cunha Pinto");
        person4.setCpf(35645593103L);

        // add address
        Address address4 = new Address();
        address4.setLogradouro("Rua João C. Ribeiro");
        address4.setNumero(560L);
        address4.setCidade("Itapevi");
        address4.setEstado("SP");
        person4.setAddress(address4);

        // add phone
        Phone phone4 = new Phone();
        phone4.setDDD(11L);
        phone4.setNumero(30301515L);
        phone4.setTipo("Residencial");
        person4.addPhone(phone4);

        // create person
        Person person5 = new Person();
        person5.setId(5L);
        person5.setNome("Carlos Dias Oliveira");
        person5.setCpf(69993567345L);

        // add address
        Address address5 = new Address();
        address5.setLogradouro("Rua Marcolina da Silva");
        address5.setNumero(789L);
        address5.setCidade("Chapeco");
        address5.setEstado("SC");
        person5.setAddress(address5);

        // add phone
        Phone phone5 = new Phone();
        phone5.setDDD(47L);
        phone5.setNumero(998822123L);
        phone5.setTipo("Celular");
        person5.addPhone(phone5);

        people.add(person1);
        people.add(person2);
        people.add(person3);
        people.add(person4);
        people.add(person5);

        PersonAdapter pa = new PersonAdapter(people, this);
        this.list.setAdapter(pa);
    }
}