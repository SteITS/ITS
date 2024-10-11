package com.astrategy.pokemine.controllers;

import com.astrategy.pokemine.entities.Card;
import com.astrategy.pokemine.services.CardService;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.http.HttpStatus;
import org.springframework.http.ResponseEntity;
import org.springframework.web.bind.annotation.GetMapping;
import org.springframework.web.bind.annotation.PathVariable;
import org.springframework.web.bind.annotation.RequestMapping;
import org.springframework.web.bind.annotation.RestController;

import java.util.List;
import java.util.Optional;

@RestController
@RequestMapping("pokemon")
public class CardController {
    @Autowired
    private CardService service;

    @GetMapping("all")
    public ResponseEntity<List<Card>> getCards() {
        return new ResponseEntity<>(service.getCards(), HttpStatus.OK);
    }

    @GetMapping("all/{id}")
    public ResponseEntity<Optional<Card>> getCardById(@PathVariable String id) {
        return new ResponseEntity<>(service.getCard(id), HttpStatus.OK);

    }

    @GetMapping("{name}")
    public ResponseEntity<List<Card>> getCardByName(@PathVariable String name) {
        return new ResponseEntity<>(service.getCardsByName(name), HttpStatus.OK);
    }
}
