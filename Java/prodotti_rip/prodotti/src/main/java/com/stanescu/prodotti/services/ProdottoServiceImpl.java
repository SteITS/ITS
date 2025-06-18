package com.stanescu.prodotti.services;

import java.util.List;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Service;

import com.stanescu.prodotti.entities.Prodotto;
import com.stanescu.prodotti.repos.ProdottoRepo;

@Service
public class ProdottoServiceImpl implements ProdottoService {

    @Autowired
    private ProdottoRepo repo;

    @Override
    public List<Prodotto> getProdotti() {
        return repo.findAll();
    }

    @Override
    public List<Prodotto> getProdottiByCategoria(String categoria) {
        return repo.findAll().stream().filter(p -> p.getCategoria().equals(categoria)).toList();
    }

    @Override
    public Prodotto getProdottoById(int id) {
        return repo.findById(id).orElse(null);
    }

    @Override
    public Prodotto addProdotto(Prodotto p) {
        return repo.save(p);
    }

    @Override
    public Prodotto updateProdotto(Prodotto p) {
        return repo.save(p);
    }

    @Override
    public void deleteProdotto(int id) {
       repo.deleteById(id);
    }

}
