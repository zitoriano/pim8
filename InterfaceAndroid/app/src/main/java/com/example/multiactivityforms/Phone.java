package com.example.multiactivityforms;

import java.io.Serializable;

public class Phone implements Serializable {
    private Long id;
    private Long DDD;
    private Long numero;
    private String tipo;

    @Override
    public String toString() {
        return "Phone{" +
                "id=" + id + ", nome='" + numero + "'}";
    }

    public Long getId() {
        return id;
    }

    public void setId(Long id) {
        this.id = id;
    }

    public Long getDDD() {
        return DDD;
    }

    public void setDDD(Long DDD) {
        this.DDD = DDD;
    }

    public Long getNumero() {
        return numero;
    }

    public void setNumero(Long numero) {
        this.numero = numero;
    }

    public String getTipo() {
        return tipo;
    }

    public void setTipo(String tipo) {
        this.tipo = tipo;
    }
}
