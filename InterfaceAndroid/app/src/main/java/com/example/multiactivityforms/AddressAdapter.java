package com.example.multiactivityforms;

import android.view.LayoutInflater;
import android.view.View;
import android.view.ViewGroup;
import android.widget.BaseAdapter;
import android.widget.TextView;

import java.util.List;

public class AddressAdapter extends BaseAdapter {

    private final List<Address> addresses;

    public AddressAdapter(List<Address> addresses) {
        this.addresses = addresses;
    }

    @Override
    public int getCount() {
        return this.addresses.size();
    }

    @Override
    public Object getItem(int position) {
        return this.addresses.get(position);
    }

    @Override
    public long getItemId(int position) {
        return this.addresses.get(position).getId();
    }

    @Override
    public View getView(int position, View convertView, ViewGroup parent) {
        View row = convertView;

        Address address = addresses.get(position);
        if(row == null) {
            row = LayoutInflater.from(parent.getContext()).inflate(
                    R.layout.address_row,
                    parent,
                    false);

            TextView txtRowAddress = (TextView) row.findViewById(R.id.txtRowAddress);
            txtRowAddress.setText(String.format("%s, %s",
                    address.getLogradouro(),
                    address.getNumero().toString()));

            TextView txtRowCityState = (TextView) row.findViewById(R.id.txtRowCityState);
            txtRowCityState.setText(String.format("%s / %s",
                    address.getCidade(),
                    address.getEstado()));
        }

        return row;
    }
}
