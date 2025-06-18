package com.stanescu.ortofrutta.entities;

import jakarta.persistence.Entity;
import jakarta.persistence.Table;
import jakarta.persistence.Id;
import lombok.Data;

@Entity
@Table(name="prodotti_ortofrutticoli")
@Data

public class Prodotto {
    @Id
    private int id;
    private String nome;
    private String categoria;
    private String origine;
    private double prezzoKg;
    private String disponibilita;
}
