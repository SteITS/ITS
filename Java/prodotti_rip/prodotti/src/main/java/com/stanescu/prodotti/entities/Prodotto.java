package com.stanescu.prodotti.entities;

import jakarta.persistence.Entity;
import jakarta.persistence.Id;
import jakarta.persistence.Table;
import lombok.AllArgsConstructor;
import lombok.Builder;
import lombok.NoArgsConstructor;

@Entity
@Table(name = "prodotti")
//@Data
@NoArgsConstructor
@AllArgsConstructor
@Builder

public class Prodotto {
    @Id
    private int id;
    private String nome;
    private String categoria;
    private double prezzo;
    private int giacenza;
    public int getId() {
        return id;
    }
    public void setId(int id) {
        this.id = id;
    }
    public String getNome() {
        return nome;
    }
    public void setNome(String nome) {
        this.nome = nome;
    }
    public String getCategoria() {
        return categoria;
    }
    public void setCategoria(String categoria) {
        this.categoria = categoria;
    }
    public double getPrezzo() {
        return prezzo;
    }
    public void setPrezzo(double prezzo) {
        this.prezzo = prezzo;
    }
    public int getGiacenza() {
        return giacenza;
    }
    public void setGiacenza(int giacenza) {
        this.giacenza = giacenza;
    }

    

}
