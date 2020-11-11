package com.example.multiactivityforms;

import android.view.LayoutInflater;
import android.view.View;
import android.view.ViewGroup;
import android.widget.BaseAdapter;
import android.widget.TextView;

import java.util.List;

public class PhoneAdapter extends BaseAdapter {
    private final List<Phone> telefones;

    public PhoneAdapter(List<Phone> telefones) {
        this.telefones = telefones;
    }

    @Override
    public int getCount() {
        return this.telefones.size();
    }

    @Override
    public Object getItem(int position) {
        return this.telefones.get(position);
    }

    @Override
    public long getItemId(int position) {
        return this.telefones.get(position).getId();
    }

    @Override
    public View getView(int position, View convertView, ViewGroup parent) {
        View row = convertView;

        Phone telefone = telefones.get(position);
        if(row == null) {
            row = LayoutInflater.from(parent.getContext()).inflate(
                    R.layout.phone_row,
                    parent,
                    false);

            TextView txtDDDPhoneType = (TextView) row.findViewById(R.id.txtDDDPhoneType);
            txtDDDPhoneType.setText(String.format("(%s) %s - %s",
                    telefone.getDDD().toString(),
                    telefone.getNumero().toString(),
                    telefone.getTipo()));
        }

        return row;
    }
}
