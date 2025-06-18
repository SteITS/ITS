package com.mary.ortofrutta.controllers;

import java.util.List;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.http.HttpStatus;
import org.springframework.http.ResponseEntity;
import org.springframework.web.bind.annotation.RequestMapping;
import org.springframework.web.bind.annotation.RestController;

import com.mary.ortofrutta.entities.Prodotto;
import com.mary.ortofrutta.services.ProdottoService;
import org.springframework.web.bind.annotation.GetMapping;


@RestController
@RequestMapping("/api")
public class ProdottiREST {
    @Autowired
    private ProdottoService prodottoService;

    @GetMapping("/getProdotti")
    public ResponseEntity<List<Prodotto>> getProdotti() {
        return new ResponseEntity<>(prodottoService.getAllProdotti(), HttpStatus.OK);
    }
    

}
