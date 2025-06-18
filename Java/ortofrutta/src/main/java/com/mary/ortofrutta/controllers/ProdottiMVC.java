package com.mary.ortofrutta.controllers;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Controller;
import org.springframework.ui.Model;

import com.mary.ortofrutta.services.ProdottoService;
import org.springframework.web.bind.annotation.GetMapping;


@Controller
public class ProdottiMVC {

    @Autowired
    private ProdottoService prodottoService;

    @GetMapping("/prodotti")
    public String getProdotti(Model m) {
        m.addAttribute("prodotti", prodottoService.getAllProdotti());
        return "prodotti";
    }
    

}
