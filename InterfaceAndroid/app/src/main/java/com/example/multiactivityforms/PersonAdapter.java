package com.example.multiactivityforms;

import android.app.Activity;
import android.view.LayoutInflater;
import android.view.View;
import android.view.ViewGroup;
import android.widget.BaseAdapter;
import android.widget.TextView;

import com.example.multiactivityforms.Person;
import com.example.multiactivityforms.R;

import java.util.List;

public class PersonAdapter extends BaseAdapter {

    private final List<Person> people;
    private final Activity activity;

    public PersonAdapter(List<Person> people, Activity activity) {
        this.people = people;
        this.activity = activity;
    }

    @Override
    public int getCount() {
        return this.people.size();
    }

    @Override
    public Object getItem(int position) {
        return this.people.get(position);
    }

    @Override
    public long getItemId(int position) {
        return this.people.get(position).getId();
    }

    @Override
    public View getView(int position, View convertView, ViewGroup parent) {
        View row = convertView;

        Person person = people.get(position);
        if(row == null) {
            row = LayoutInflater.from(parent.getContext()).inflate(
                    R.layout.person_row,
                    parent,
                    false);

            TextView txtRowNome = (TextView) row.findViewById(R.id.txtRowNome);
            TextView txtRowCPF = (TextView) row.findViewById(R.id.txtRowCPF);
            TextView txtRowFone = (TextView) row.findViewById(R.id.txtRowFone);
            TextView txtRowEndereco = (TextView) row.findViewById(R.id.txtRowEndereco);

            txtRowNome.setText(person.getNome());

            txtRowCPF.setText(String.format("CPF %s",
                    person.getCpf().toString()));

            txtRowFone.setText(String.format("(%s) %s - %s",
                    11L,
                    30535599L,
                    "residencial"));

            txtRowEndereco.setText(String.format("%s, %s - %s / %s",
                    "Rua Bezerra de Menezes",
                    174L,
                    "Leme",
                    "São Paulo"));
        }

        return row;
    }
}
