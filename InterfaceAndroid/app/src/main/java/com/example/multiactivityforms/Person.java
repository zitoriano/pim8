package com.example.multiactivityforms;
import com.example.multiactivityforms.Address;

import java.io.Serializable;
import java.util.ArrayList;
import java.util.List;

public class Person implements Serializable {
    private Long id;
    private String nome;
    private Long cpf;
    private Address endereco;
    private List<Phone> telefones;

    public Person() {
        this.telefones = new ArrayList<>();
    }

    @Override
    public String toString() {
        return "Person{" +
                "id=" + id + ", nome='" + nome + "'}";
    }

    public Long getId() {
        return id;
    }

    public void setId(Long id) {
        this.id = id;
    }

    public String getNome() {
        return nome;
    }

    public void setNome(String nome) {
        this.nome = nome;
    }

    public Long getCpf() {
        return cpf;
    }

    public void setCpf(Long cpf) {
        this.cpf = cpf;
    }

    public Address getAddress()
    {
        return this.endereco;
    }

    public void setAddress(Address endereco)
    {
        this.endereco = endereco;
    }

    public List<Phone> getPhones()
    {
        return this.telefones;
    }

    public void addPhone(Phone telefone)
    {
        this.telefones.add(telefone);
    }
}
