package com.mary.ortofrutta.services;

import java.util.List;

import org.springframework.stereotype.Service;

import com.mary.ortofrutta.entities.Prodotto;

@Service
public interface ProdottoService {
    List<Prodotto> getAllProdotti();
    Prodotto getProdottoById(int id);
    List<Prodotto> getProdottiByCategoria(String categoria);
    Prodotto addProdotto(Prodotto prodotto);
    Prodotto updateProdotto(Prodotto prodotto);
    void deleteProdotto(int id);
}
