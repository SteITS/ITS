package com.mary.ortofrutta.entities;

import jakarta.persistence.Column;
import jakarta.persistence.Entity;
import jakarta.persistence.GeneratedValue;
import jakarta.persistence.GenerationType;
import jakarta.persistence.Id;
import jakarta.persistence.Table;
import lombok.Data;

@Entity
@Table(name="prodotti_ortofrutticoli")
@Data
public class Prodotto {
    @Id
    @GeneratedValue(strategy=GenerationType.IDENTITY)
    private int id;

    @Column(columnDefinition = "VARCHAR(100)", nullable = false)
    private String nome;

    
    private String categoria;
    private String origine;
    private double prezzoKg;
    private String disponibilita;

}
