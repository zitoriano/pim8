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
        person1.setNome("Marcos Felipe");
        person1.setCpf(111111111L);

        // create person
        Person person2 = new Person();
        person2.setId(2L);
        person2.setNome("Alexandre de Paula");
        person2.setCpf(111111111L);

        // create person
        Person person3 = new Person();
        person3.setId(3L);
        person3.setNome("Mauricio Nunes");
        person3.setCpf(111111111L);

        // create person
        Person person4 = new Person();
        person4.setId(4L);
        person4.setNome("Mauricio Nunes");
        person4.setCpf(111111111L);

        // create person
        Person person5 = new Person();
        person5.setId(5L);
        person5.setNome("Mauricio Nunes");
        person5.setCpf(111111111L);

        people.add(person1);
        people.add(person2);
        people.add(person3);
        people.add(person4);
        people.add(person5);

        PersonAdapter pa = new PersonAdapter(people, this);
        this.list.setAdapter(pa);
    }
}