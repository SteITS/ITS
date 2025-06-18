package com.mary.ortofrutta.services;

import java.util.List;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Service;

import com.mary.ortofrutta.entities.Prodotto;
import com.mary.ortofrutta.repos.ProdottoRepo;


@Service
public class ProdottoServiceImpl implements ProdottoService {
    @Autowired
    private ProdottoRepo prodottoRepo;

    @Override
    public List<Prodotto> getAllProdotti() {
        return prodottoRepo.findAll();
    }

    @Override
    public Prodotto getProdottoById(int id) {
        return prodottoRepo.findById(id).orElseThrow();
    }

    @Override
    public List<Prodotto> getProdottiByCategoria(String categoria) {
        return prodottoRepo.findAll().stream()
                .filter(prodotto -> prodotto.getCategoria().equalsIgnoreCase(categoria))
                .toList();
    }

    @Override
    public Prodotto addProdotto(Prodotto prodotto) {
        return prodottoRepo.save(prodotto);
    }

    @Override
    public Prodotto updateProdotto(Prodotto prodotto) {
        return prodottoRepo.save(prodotto);
    }

    @Override
    public void deleteProdotto(int id) {
         prodottoRepo.deleteById(id);
    }

}
