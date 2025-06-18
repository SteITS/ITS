package com.stanescu.prodotti.controller;

import java.util.List;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.web.bind.annotation.RequestMapping;
import org.springframework.web.bind.annotation.RestController;

import com.stanescu.prodotti.entities.Prodotto;
import com.stanescu.prodotti.services.ProdottoService;
import org.springframework.web.bind.annotation.GetMapping;
import org.springframework.web.bind.annotation.PathVariable;

@RestController
@RequestMapping("api")
public class ProdottiRest{

    @Autowired
    private ProdottoService service;

    @GetMapping("prodotti")
    public List<Prodotto> getProdotti() {
        return service.getProdotti();
    }
    
    @GetMapping("prodotticat/{categoria}")
    public List<Prodotto> getbyProdotto(@PathVariable("categoria") String categoria) {
        return service.getProdottiByCategoria(categoria);
    }
    
    
}
